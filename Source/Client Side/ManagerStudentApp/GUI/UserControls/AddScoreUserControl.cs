using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerStudentLib.Models;
using ManagerStudentLib.Data;
using ManagerStudentApp.Exceptions;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class AddScoreUserControl : UserControl
    {
        private List<ClassInfo> listClassInfo;
        private List<SubjectInfo> listSubjectInfo;
        private List<SemesterInfo> listSemesterInfo;

        private List<StudentWithScore> listStudentWithScores;
        private List<ScoreType> listScoreTypes;

        public AddScoreUserControl()
        {
            InitializeComponent();
        }

        private void AddScoreUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listClassInfo = ClassData.GetListClasses();
            listSubjectInfo = SubjectData.GetListSubject();
            listSemesterInfo = SemesterData.GetListSemester();
            listScoreTypes = ScoreData.GetScoreTypes();
            cbbLop.Items.Add("Chưa chọn");
            cbbMon.Items.Add("Chưa chọn");
            cbbHocKi.Items.Add("Chưa chọn");
            foreach (var c in listClassInfo)
            {
                cbbLop.Items.Add(c.Name);
            }
            foreach (var s in listSubjectInfo)
            {
                cbbMon.Items.Add(s.Name);
            }
            foreach (var sem in listSemesterInfo)
            {
                cbbHocKi.Items.Add(sem.Name);
            }
            cbbLop.SelectedIndex = 0;
            cbbMon.SelectedIndex = 0;
            cbbHocKi.SelectedIndex = 0;
            btnCapNhatDiem.Enabled = false;
        }

        private void cbbSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataStudents();
        }

        private void LoadDataStudents()
        {
            dgvDiem.Rows.Clear();
            if (cbbMon.SelectedIndex <= 0 || cbbLop.SelectedIndex <= 0 || cbbHocKi.SelectedIndex <= 0)
            {
                listStudentWithScores = new List<StudentWithScore>();
                btnCapNhatDiem.Enabled = false;
                return;
            }
            else
            {
                var loadScoreInfo = new LoadScoreInfo()
                {
                    ClassId = listClassInfo[cbbLop.SelectedIndex - 1].Id,
                    CourseId = listSubjectInfo[cbbMon.SelectedIndex - 1].Id,
                    SemesterId = listSemesterInfo[cbbHocKi.SelectedIndex - 1].Id
                };
                listStudentWithScores = ScoreData.GetStudentWithScores(loadScoreInfo);
            }

            foreach (StudentWithScore st in listStudentWithScores)
            {
                var row = new string[] { st.Student.UserCode.ToString(), st.Student.UserInfo.Name, "", "", "" };
                var scores = new string[] { "", "", "" };
                var scoreObs = new ScoreInfo[3];
                foreach (ScoreInfo score in st.ListScore)
                {
                    if (score.ScoreType.Coefficient == 1)
                    {
                        scores[0] = score.Score.ToString();
                        scoreObs[0] = score;
                    }
                    else if (score.ScoreType.Coefficient == 2)
                    {
                        scores[1] = score.Score.ToString();
                        scoreObs[1] = score;
                    }
                    else
                    {
                        scores[2] = score.Score.ToString();
                        scoreObs[2] = score;
                    }
                }
                row[2] = scores[0];
                row[3] = scores[1];
                row[4] = scores[2];
                
                DataGridViewRow r = new DataGridViewRow();
                foreach (string str in row) {
                    DataGridViewTextBoxCell e = new DataGridViewTextBoxCell();
                    e.Value = str;
                    r.Cells.Add(e);
                }
                r.Cells[2].Tag = scoreObs[0];
                r.Cells[3].Tag = scoreObs[1];
                r.Cells[4].Tag = scoreObs[2];
                dgvDiem.Rows.Add(r);
            }
            btnCapNhatDiem.Enabled = true;
        }

        private void dgvDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiem.CurrentCell.ColumnIndex >= 2)
            {
                dgvDiem.BeginEdit(false);
                dgvDiem.CurrentCell.ReadOnly = false;
            }
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            var updateScores = new List<ScoreInfo>();
            var addScores = new List<AddScoreInfo>();
            var delScores = new List<string>();
            for (int i = 0; i < dgvDiem.Rows.Count; ++i ) {
                var row = dgvDiem.Rows[i];
                var studentId = listStudentWithScores[i].Student.Id;
                var subjectId = listSubjectInfo[cbbMon.SelectedIndex - 1].Id;
                var semesterId = listSemesterInfo[cbbHocKi.SelectedIndex - 1].Id;
                for (int k = 2; k <= 4; ++k)
                {
                    if (row.Cells[k].Value != null && IsValidCellValue(row.Cells[k].Value.ToString()))
                    {
                        string value = row.Cells[k].Value.ToString();
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            if (row.Cells[k].Tag != null)
                            {
                                var score = (ScoreInfo)row.Cells[k].Tag;
                                delScores.Add(score.Id);
                            }
                        }
                        else
                        {
                            if (row.Cells[k].Tag != null)
                            {
                                var score = (ScoreInfo)row.Cells[k].Tag;
                                var scoreNewValue = decimal.Parse(row.Cells[k].Value.ToString().Trim());
                                score.Score = scoreNewValue;
                                updateScores.Add(score);
                            }
                            else
                            {
                                var scoreNewValue = decimal.Parse(row.Cells[k].Value.ToString().Trim());
                                var scoreTypeId = GetScoreTypeId(k);
                                var newScore = new AddScoreInfo()
                                {
                                    Score = scoreNewValue,
                                    StudentId = studentId,
                                    CourseId = subjectId,
                                    SemesterId = semesterId,
                                    ScoreTypeId = scoreTypeId
                                };
                                addScores.Add(newScore);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Chỉ chấp nhận điểm là số và 10 >= điểm >= 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            var updateInfo = new UpdateStudentWithScore()
            {
                ScoresUpdate = updateScores,
                ScoresAdd = addScores,
                ScoresDelete = delScores
            };
            try
            {
                MessageBox.Show(this, ScoreData.UpdateScores(updateInfo), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataStudents();
        }

        // hard code the scoreType for cell 2,3,4
        private string GetScoreTypeId(int numCell)
        {
            if (numCell < 2)
            {
                return string.Empty;
            }
            if (numCell == 2)
            {
                return GetScoreTypeIdWithCoefficient(1);
            }
            if (numCell == 3)
            {
                return GetScoreTypeIdWithCoefficient(2);
            }
            return GetScoreTypeIdWithCoefficient(3);
        }

        private string GetScoreTypeIdWithCoefficient(int coefficient)
        {
            foreach (ScoreType scoreType in listScoreTypes)
            {
                if (scoreType.Coefficient == coefficient)
                {
                    return scoreType.Id;
                }
            }
            return string.Empty;
        }

        private bool IsValidCellValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            decimal intValue = -1;
            if (decimal.TryParse(value, out intValue))
            {
                return intValue >= 0 && intValue <= 10;
            }
            return false;
        }

    }
}

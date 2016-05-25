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

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class ListScoreUserControl : UserControl
    {

        private List<ClassInfo> listClassInfo;
        private List<SubjectInfo> listSubjectInfo;
        private List<SemesterInfo> listSemesterInfo;

        private List<StudentWithScore> listStudentWithScores;

        public ListScoreUserControl()
        {
            InitializeComponent();
        }

        private void ListScoreUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listClassInfo = ClassData.GetListClasses();
            listSubjectInfo = SubjectData.GetListSubject();
            listSemesterInfo = SemesterData.GetListSemester();
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

            foreach (StudentWithScore st in  listStudentWithScores)
            {
                var row = new string[] { st.Student.BadgeId.ToString() , st.Student.UserInfo.Name , "" , "", ""};
                var scores = new string[] { "", "", "" };
                foreach (ScoreInfo score in st.ListScore)
                {
                    if (score.ScoreType.Coefficient == 1)
                    {
                        scores[0] = score.Score.ToString();
                    } else if (score.ScoreType.Coefficient == 2)
                    {
                        scores[1] = score.Score.ToString();
                    } else
                    {
                        scores[2] = score.Score.ToString();
                    }
                }
                row[2] = scores[0];
                row[3] = scores[1];
                row[4] = scores[2];
                dgvDiem.Rows.Add(row);
            }
        }

    }
}

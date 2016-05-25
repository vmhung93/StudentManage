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
using ManagerStudentLib.Service;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class AddReportSemsterUserControl : UserControl
    {
        private List<SemesterInfo> listSemesterInfo;
        private List<ScoreType> listScoreType;

        public AddReportSemsterUserControl()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            listSemesterInfo = SemesterData.GetListSemester();
            listScoreType = ScoreData.GetScoreTypes();
            cbbHocKi.Items.Add("Chưa chọn");
            foreach (var sem in listSemesterInfo)
            {
                cbbHocKi.Items.Add(sem.Name);
            }
            cbbHocKi.SelectedIndex = 0;
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (cbbHocKi.SelectedIndex != 0)
            {
                lvTongKet.Items.Clear();
                double sumCofficient = 0;
                decimal passScore = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.PassScore);
                foreach (var sct in listScoreType)
                {
                    sumCofficient += sct.Coefficient;
                }
                List<SummarySemester> summary = SemesterData.GetSummarySemester(listSemesterInfo[cbbHocKi.SelectedIndex - 1].Id);
                int i = 1;
                foreach (var s in summary)
                {
                    int numStudentPass = 0;
                    foreach(var student in s.StudentCourses)
                    {
                        int coursePass = 0;
                        foreach (var course in student.CourseScores)
                        {
                            double sum = 0;
                            foreach (var score in course.Scores)
                            {
                                sum += Convert.ToDouble(score.Score) * score.ScoreType.Coefficient;
                            }
                            sum = sum / sumCofficient;
                            if (sum >= (double)passScore)
                            {
                                coursePass += 1;
                            }
                        }
                        if(coursePass == student.CourseScores.Count)
                        {
                            numStudentPass += 1;
                        }
                    }
                    string[] row = { i.ToString(), s.Class.Name, s.StudentCourses.Count.ToString(), numStudentPass.ToString(), s.StudentCourses.Count > 0 ? (numStudentPass * 1.0f / s.StudentCourses.Count).ToString() : "0" };
                    lvTongKet.Items.Add(new ListViewItem(row));
                    ++i;
                }
            }
        }

        private void AddReportSemsterUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

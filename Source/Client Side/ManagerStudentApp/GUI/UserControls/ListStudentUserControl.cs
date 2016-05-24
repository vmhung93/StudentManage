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
    public partial class ListStudentUserControl : UserControl
    {
        private List<ScoreType> listScoreType;
        double sumCofficient = 0;

        public ListStudentUserControl()
        {
            InitializeComponent();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text != null)
            {
                lvwDanhSach.Items.Clear();
                List<StudentClassCourseScore> students = ScoreData.GetStudentClassCourseScore(txtHoTen.Text);
                int i = 1;
                foreach (var student in students)
                {
                    int j = 0;
                    double[] avgSemester = new double[student.SemesterCourses.Count];
                    foreach (var semester in student.SemesterCourses)
                    {
                        double sem = 0;
                        foreach (var course in semester.CourseScores)
                        {
                            double sum = 0;
                            foreach (var score in course.Scores)
                            {
                                sum += Convert.ToDouble(score.Score) * score.ScoreType.Coefficient;
                            }
                            sum = sum / sumCofficient;
                            sem += sum;
                        }
                        sem = sem / semester.CourseScores.Count;
                        avgSemester[j] = sem;
                        j++;
                    }
                    string[] str = { i.ToString(), student.StudentName, student.ClassName, avgSemester[0].ToString(), avgSemester[1].ToString() };
                    lvwDanhSach.Items.Add(new ListViewItem(str));
                    i++;
                }
            }
        }

        private void ListStudentUserControl_Load(object sender, EventArgs e)
        {
            listScoreType = ScoreData.GetScoreTypes();
            foreach (var sct in listScoreType)
            {
                sumCofficient += sct.Coefficient;
            }
        }
    }
}

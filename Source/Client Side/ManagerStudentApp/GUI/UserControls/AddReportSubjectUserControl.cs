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
    public partial class AddReportSubjectUserControl : UserControl
    {
        private List<SubjectInfo> listSubjectInfo;
        private List<SemesterInfo> listSemesterInfo;
        private List<ScoreType> listScoreType;

        public AddReportSubjectUserControl()
        {
            InitializeComponent();
        }

        private void AddReportSubjectUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listSubjectInfo = SubjectData.GetListSubject();
            listSemesterInfo = SemesterData.GetListSemester();
            listScoreType = ScoreData.GetScoreTypes();
            cbbMon.Items.Add("Chưa chọn");
            cbbHocKi.Items.Add("Chưa chọn");
            foreach (var c in listSubjectInfo)
            {
                cbbMon.Items.Add(c.Name);
            }
            foreach (var sem in listSemesterInfo)
            {
                cbbHocKi.Items.Add(sem.Name);
            }
            cbbMon.SelectedIndex = 0;
            cbbHocKi.SelectedIndex = 0;
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if(cbbMon.SelectedIndex != 0 || cbbHocKi.SelectedIndex != 0)
            {
                lvTongKet.Items.Clear();
                decimal passScore = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.PassScore);
                GetSummarySubject summarySubject = new GetSummarySubject()
                {
                    CourseId = listSubjectInfo[cbbMon.SelectedIndex - 1].Id,
                    SemesterId = listSemesterInfo[cbbHocKi.SelectedIndex - 1].Id
                };
                double sumCofficient = 0;
                foreach (var sct in listScoreType)
                {
                    sumCofficient += sct.Coefficient;
                }
                List<SummarySubject> summary = SubjectData.GetSummarySubject(summarySubject);
                int i = 1;
                foreach (var s in summary)
                {
                    string className = s.Class.Name;
                    int numStudentPass = 0;
                    foreach(var st in s.StudentScore)
                    {
                        double sum = 0;
                        foreach(var sc in st.ListScore)
                        {
                            sum += Convert.ToDouble(sc.Score) * sc.ScoreType.Coefficient;
                        }
                        sum = sum / sumCofficient;
                        if (sum >= (double)passScore)
                        {
                            numStudentPass += 1;
                        }
                    }
                    string[] row = { i.ToString(), s.Class.Name, s.StudentScore.Count.ToString(), numStudentPass.ToString(), s.StudentScore.Count > 0 ? (numStudentPass * 1.0f / s.StudentScore.Count).ToString() : "0" };
                    lvTongKet.Items.Add(new ListViewItem(row));
                    ++i;
                }
            }
        }
    }
}

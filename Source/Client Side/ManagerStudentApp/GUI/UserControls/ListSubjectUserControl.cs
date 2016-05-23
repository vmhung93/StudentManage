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
    public partial class ListSubjectUserControl : UserControl
    {
        List<SubjectInfo> listSubjectInfo = new List<SubjectInfo>();

        public ListSubjectUserControl()
        {
            InitializeComponent();
        }

        private void ListSubjectUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listSubjectInfo = SubjectData.GetListSubject();
            FillData();
        }
        private void FillData()
        {
            int i = 1;
            foreach (var subject in listSubjectInfo)
            {
                var item = new ListViewItem(new String[] { i.ToString(), subject.Name });
                lvSubjects.Items.Add(item);
                i++;
            }
        }
    }
}

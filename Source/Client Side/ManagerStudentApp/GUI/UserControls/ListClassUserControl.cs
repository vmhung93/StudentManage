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
    public partial class ListClassUserControl : UserControl
    {
        List<ClassInfo> listClassInfo = new List<ClassInfo>();
        ClassInfoWithStudents currentClass;
        public ListClassUserControl()
        {
            InitializeComponent();
        }

        private void ListClassUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listClassInfo = ClassData.GetListClasses();
            LoadListClasses();
        }

        private void LoadListClasses()
        {
            this.comboBoxDsLop.Items.Clear();
            foreach (ClassInfo classInfo in listClassInfo)
            {
                this.comboBoxDsLop.Items.Add(classInfo.Name);
            }
            if (this.comboBoxDsLop.Items.Count > 0)
            {
                this.comboBoxDsLop.SelectedIndex = 0;
            }
        }

        private void ClearData()
        {
            txtTenLopHienTai.Text = "";
            txtTenGVHienTai.Text = "";
            txtKhoiLop.Text = "";
            txtSiSo.Text = "";

            lvDsHocSinh.Items.Clear();
        }

        private void LoadInfoClass()
        {
            if (currentClass != null) {
                txtTenLopHienTai.Text = currentClass.Class.Name;
                txtTenGVHienTai.Text = currentClass.Class.HomeroomTeacher.UserInfo.Name;
                txtKhoiLop.Text = currentClass.Class.Grade.Name;
                txtSiSo.Text = currentClass.Students.Count.ToString();

                lvDsHocSinh.Items.Clear();
                int i = 1;
                foreach (User st in currentClass.Students)
                {
                    var item = new ListViewItem(new String[] { i.ToString(), st.UserInfo.Name, st.UserInfo.DateOfBirth.ToShortDateString(), st.UserInfo.Address });
                    lvDsHocSinh.Items.Add(item);
                    ++i;
                }
            }
        }

        private void comboBoxDsLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDsLop.SelectedIndex >= 0)
            {
                currentClass = ClassData.GetInfoClassWithStudents(listClassInfo[comboBoxDsLop.SelectedIndex].Id);
                ClearData();
                LoadInfoClass();
            } 
        }
    }
}

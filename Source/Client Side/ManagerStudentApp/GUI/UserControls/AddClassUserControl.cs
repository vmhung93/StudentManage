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
using ManagerStudentLib.Service;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class AddClassUserControl : UserControl
    {
        private List<User> originalStudents = new List<User>();
        private List<User> addedStudents = new List<User>();
        private List<User> preAddStudents = new List<User>();
        private List<User> teachers = new List<User>();
        private List<Grade> grades = new List<Grade>();
        private int currentNum = -1;
        public AddClassUserControl()
        {
            InitializeComponent();
        }

        private void AddClassUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PreLoadAddClassInfo pre = ClassData.GetInfoForAddClass();
            this.originalStudents = pre.Students;
            this.teachers = pre.HomeroomTeacherdes;
            this.grades = pre.grades;
            ResetData();
            LoadNumMaxStudent();
        }
        private void ResetData()
        {
            this.preAddStudents.Clear();
            this.addedStudents.Clear();
            this.preAddStudents.AddRange(this.originalStudents);
            LoadAddedStudents();
            LoadPreStudents();
            LoadTeacher();
            LoadNumAddStudent();
            LoadGrades();
            this.txtTenLop.Focus();
        }

        private void LoadTeacher()
        {
            comboBoxGVCN.Items.Clear();

            foreach (User teacher in this.teachers)
            {
                comboBoxGVCN.Items.Add(teacher.UserInfo.Name);
            }
            if (comboBoxGVCN.Items.Count > 0)
            {
                comboBoxGVCN.SelectedIndex = 0;
            }
        }

        private void LoadGrades()
        {
            comboBoxKhoiLop.Items.Clear();
            foreach (Grade g in this.grades) 
            {
                comboBoxKhoiLop.Items.Add(g.Name);
            }
            if (comboBoxKhoiLop.Items.Count > 0)
            {
                comboBoxKhoiLop.SelectedIndex = 0;
            }
        }
        private void LoadPreStudents()
        {
            this.lvLop.Items.Clear();
            foreach (User st in this.preAddStudents)
            {
                var item = new ListViewItem(new String[] { st.UserCode.ToString(), st.UserInfo.Name });
                lvLop.Items.Add(item);
            }
        }

        private void LoadAddedStudents()
        {
            this.lvLopSelect.Items.Clear();
            foreach (User st in this.addedStudents)
            {
                var item = new ListViewItem(new String[] { st.UserCode.ToString(), st.UserInfo.Name });
                lvLopSelect.Items.Add(item);
            }
        }

        private void LoadNumAddStudent()
        {
            currentNum = this.lvLopSelect.Items.Count;
            decimal maxNum = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass);
            int remain = currentNum - (int)maxNum;
            string strValue = currentNum.ToString();
            this.txtSiSo.BackColor = this.txtSiSo.BackColor;
            if (remain > 0) {
                strValue = String.Format("{0}+{1}", currentNum, remain);
                this.txtSiSo.ForeColor = Color.OrangeRed;
            }
            else
            {
                this.txtSiSo.ForeColor = Color.LimeGreen;
            }
            this.txtSiSo.Text = strValue;
        }

        private void LoadNumMaxStudent()
        {
            this.txtSiSoToiDa.Text = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedIndices.Count > 0)
            {
                var listSelected = new List<User>();
                foreach (int index in lvLop.SelectedIndices) {
                    listSelected.Add(this.preAddStudents[index]);
                }
                foreach (User st in listSelected)
                {
                    this.preAddStudents.Remove(st);
                }
                this.addedStudents.AddRange(listSelected);
                LoadPreStudents();
                LoadAddedStudents();
                LoadNumAddStudent();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (lvLop.Items.Count > 0)
            {
                this.addedStudents.AddRange(this.preAddStudents);
                this.preAddStudents.Clear();
                LoadPreStudents();
                LoadAddedStudents();
                LoadNumAddStudent();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (lvLopSelect.SelectedIndices.Count > 0)
            {
                var listSelected = new List<User>();
                foreach (int index in lvLopSelect.SelectedIndices)
                {
                    listSelected.Add(this.addedStudents[index]);
                }
                foreach (User st in listSelected)
                {
                    this.addedStudents.Remove(st);
                }
                this.preAddStudents.AddRange(listSelected);
                LoadPreStudents();
                LoadAddedStudents();
                LoadNumAddStudent();
            }
        }

        private void btnSubtractAll_Click(object sender, EventArgs e)
        {
            if (lvLopSelect.Items.Count > 0)
            {
                this.preAddStudents.AddRange(this.addedStudents);
                this.addedStudents.Clear();
                LoadPreStudents();
                LoadAddedStudents();
                LoadNumAddStudent();
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void btnLapLop_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show(this, "Tên lớp không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
            if (comboBoxGVCN.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Chủ nhiệm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxKhoiLop.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Khối lớp không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentNum > SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass))
            {
                MessageBox.Show(this, "Sỉ số lớp vượt mức quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var teacherId = teachers[comboBoxGVCN.SelectedIndex].Id;
            var gradeId = grades[comboBoxKhoiLop.SelectedIndex].Id;
            var studentIds = new List<string>();
            foreach (User st in this.addedStudents) {
                studentIds.Add(st.Id);
            }
            var classInfo = new ClassInfo()
            {
                Name = txtTenLop.Text,
                HomeroomTeacherId = teacherId,
                GradeId = gradeId,
                CreatedBy = "073f4124-df1d-e611-832c-14dda9bd8fb8"
            };

            ClassInfoWithStudentIds addClassInfo = new ClassInfoWithStudentIds()
            {
                Class = classInfo,
                StudentIds = studentIds
            };
            try
            {
                MessageBox.Show(this, ClassData.AddClass(addClassInfo), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadData();
            } catch (DataGetException ex) {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class ChangeClassUserControl : UserControl
    {
        private List<User> originalFreeStudents = new List<User>();
        private List<User> addedStudents = new List<User>();
        private List<User> preAddStudents = new List<User>();
        private List<ClassInfo> classes = new List<ClassInfo>();
        private List<User> teachers = new List<User>();
        private List<Grade> grades = new List<Grade>();
        private ClassInfoWithStudents currentClass;
        private int currentNum = -1;

        public ChangeClassUserControl()
        {
            InitializeComponent();
        }

        private void ChangeClassUserControl_Load(object sender, EventArgs e)
        {
            LoadClassesData();
            LoadData();
        }

        private void LoadData()
        {
            PreLoadAddClassInfo preLoad = ClassData.GetInfoForAddClass();
            originalFreeStudents = preLoad.Students;
            teachers = preLoad.HomeroomTeacherdes;
            grades = preLoad.grades;
            LoadGrades();
            LoadTeachers();
            LoadNumMaxStudent();
        }

        private void LoadClassesData()
        {
            classes = ClassData.GetListClasses();
            LoadClasses();
        }

        private void ResetCurrentClassData()
        {
            var tenLopHienTai = String.Empty;
            var gvncHienTai = String.Empty;
            var khoiLopHienTai = String.Empty;
            int numStudents = 0;
            int khoiLopIndex = 0;
            int gvncIndex = 0;
            addedStudents.Clear();
            if (currentClass != null)
            {
                tenLopHienTai = currentClass.Class.Name;
                gvncHienTai = currentClass.Class.HomeroomTeacher.UserInfo.Name;
                khoiLopHienTai = currentClass.Class.Grade.Name;
                addedStudents.AddRange(currentClass.Students);
                numStudents = currentClass.Students.Count;
            }
            txtSiSo.Text = numStudents.ToString();
            txtTenLop.Text = String.Empty;
            txtTenLopHienTai.Text = tenLopHienTai;
            txtTenGVHienTai.Text = gvncHienTai;
            txtKhoiLopHienTai.Text = khoiLopHienTai;
            comboBoxKhoiLop.SelectedIndex = khoiLopIndex;
            comboBoxGVCN.SelectedIndex = gvncIndex;

            preAddStudents.Clear();
            preAddStudents.AddRange(originalFreeStudents);

            LoadAddedStudents();
            LoadPreStudents();
        }

        private void LoadAddedStudents()
        {
            lvLopSelect.Items.Clear();
            foreach (User st in addedStudents)
            {
                var item = new ListViewItem(new String[] { st.UserName.ToString(), st.UserInfo.Name, st.UserInfo.DateOfBirth.ToShortDateString() });
                lvLopSelect.Items.Add(item);
            }
        }

        private void LoadPreStudents()
        {
            lvLop.Items.Clear();
            foreach (User st in preAddStudents)
            {
                var item = new ListViewItem(new String[] { st.UserName.ToString(), st.UserInfo.Name, st.UserInfo.DateOfBirth.ToShortDateString() });
                lvLop.Items.Add(item);
            }
        }

        private void LoadGrades()
        {
            comboBoxKhoiLop.Items.Clear();
            comboBoxKhoiLop.Items.Add("Không đổi");
            foreach (Grade g in grades) 
            {
                comboBoxKhoiLop.Items.Add(g.Name);
            }
            comboBoxKhoiLop.SelectedIndex = 0;
        }

        private void LoadTeachers()
        {
            comboBoxGVCN.Items.Clear();
            comboBoxGVCN.Items.Add("Không đổi");
            foreach (User teacher in teachers)
            {
                comboBoxGVCN.Items.Add(teacher.UserInfo.Name);
            }
            comboBoxGVCN.SelectedIndex = 0;
        }

        private void LoadClasses()
        {
            comboBoxLop.Items.Clear();
            comboBoxLop.Items.Add("Chưa chọn");
            foreach (ClassInfo classInfo in classes) 
            {
                comboBoxLop.Items.Add(classInfo.Name);
            }
            comboBoxLop.SelectedIndex = 0;
        }

        private void LoadNumAddStudent()
        {
            currentNum = this.lvLopSelect.Items.Count;
            decimal maxNum = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass);
            int remain = currentNum - (int)maxNum;
            string strValue = currentNum.ToString();
            if (remain > 0)
            {
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

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLop.SelectedIndex > 0)
            {
                int index = comboBoxLop.SelectedIndex;
                string classId = classes[index-1].Id;
                currentClass = ClassData.GetInfoClassWithStudents(classId);
                ResetCurrentClassData();
            }
        }


        private void btnCapNhatLop_Click(object sender, EventArgs e)
        {
            if (currentClass == null)
            {
                MessageBox.Show(this, "Chưa chọn lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (currentNum > SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass))
            {
                MessageBox.Show(this, "Sỉ số lớp vượt mức quy định", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newStudentIds = new List<string>();
            var substractStudentIds = new List<string>();

            foreach (User st in addedStudents)
            {
                if (!currentClass.Students.Contains(st))
                {
                    newStudentIds.Add(st.Id);
                }
            }

            foreach (User st in currentClass.Students)
            {
                if (!addedStudents.Contains(st))
                {
                    substractStudentIds.Add(st.Id);
                }
            }
            
            string gradeId = currentClass.Class.GradeId;
            string teacherId = currentClass.Class.HomeroomTeacherId;
            string name = currentClass.Class.Name;
            if (!String.IsNullOrWhiteSpace(txtTenLop.Text)) {
                name = txtTenLop.Text.Trim();
            }

            if (comboBoxKhoiLop.SelectedIndex > 0) {
                gradeId = grades[comboBoxKhoiLop.SelectedIndex-1].Id;
            }

            if (comboBoxGVCN.SelectedIndex > 0) {
                teacherId = teachers[comboBoxGVCN.SelectedIndex-1].Id;
            }

            var updateClass = new ClassInfo() {
                Id = currentClass.Class.Id,
                Name = name,
                GradeId = gradeId,
                HomeroomTeacherId = teacherId
            };

            var updateInfo = new UpdateClassInfoWithStudentIds()
            {
                Class = updateClass,
                AddStudentIds = newStudentIds,
                SubstractStudentIds = substractStudentIds
            };

            try
            {
                MessageBox.Show(this, ClassData.UpdateClass(updateInfo), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadData();
                ResetCurrentClassData();
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ResetCurrentClassData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvLop.SelectedIndices.Count > 0)
            {
                var listSelected = new List<User>();
                foreach (int index in lvLop.SelectedIndices)
                {
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

        private void btnSubstract_Click(object sender, EventArgs e)
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

        private void btnSubstractAll_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentClass == null)
            {
                MessageBox.Show(this, "Chưa chọn lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(this, "Bạn thật sự muốn xoá lớp", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}

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
    public partial class ChangeSubjectUserControl : UserControl
    {
        List<SubjectInfo> listSubjectInfo = new List<SubjectInfo>();

        SubjectInfo currentSubject;

        public ChangeSubjectUserControl()
        {
            InitializeComponent();
        }

        private void lvSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSubjects.SelectedIndices.Count > 0)
            {
                currentSubject = listSubjectInfo[lvSubjects.SelectedIndices[0]];
                LoadCurrentSubject();
            }
        }

        private void ChangeSubjectUserControl_Load(object sender, EventArgs e)
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

        private void LoadCurrentSubject()
        {
            if (currentSubject != null)
            {
                txtSubjectName.Text = currentSubject.Name;
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadData();
            if (lvSubjects.Items.Count > 0)
            {
                lvSubjects.Items[0].Selected = true;
            }
        }

        private void btnHuyMonHoc_Click(object sender, EventArgs e)
        {
            if (currentSubject == null)
            {
                MessageBox.Show(this, "Chưa chọn môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show(this, "Bạn thật sự muốn xoá môn học", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                MessageBox.Show(this, SubjectData.DeleteSubject(currentSubject), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show(this, "Tên môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentSubject.Name = txtSubjectName.Text.Trim();
            try
            {
                MessageBox.Show(this, SubjectData.UpdateSubject(currentSubject), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

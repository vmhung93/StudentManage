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
    public partial class AddSubjectUserControl : UserControl
    {
        public AddSubjectUserControl()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show(this, "Tên môn học không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CreateSubject newSubject = new CreateSubject() { Name = txtSubjectName.Text };
            try
            {
                MessageBox.Show(this, SubjectData.AddSubject(newSubject), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text = "";
        }

        private void AddSubjectUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}

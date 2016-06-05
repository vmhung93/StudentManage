using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Models;
using ManagerStudentLib.Authentication;
using ManagerStudentLib.Data;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class ChangePasswordUserControl : UserControl
    {
        public ChangePasswordUserControl()
        {
            InitializeComponent();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật khẩu cũ không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show(this, "Mẫu khẩu mới không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtNhapLaiMatKhau.Text.Equals(txtMatKhauMoi.Text))
            {
                MessageBox.Show(this, "Mẫu khẩu nhập lại không giống mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try 
            {
                var updatePass = new PasswordInfo()
                {
                    UserId = AuthenticationService.GetInstance().GetCurrentUser().Id,
                    CurrentPassword = txtMatKhauCu.Text,
                    NewPassword = txtMatKhauMoi.Text,
                    ConfirmPassword = txtNhapLaiMatKhau.Text
                };

                MessageBox.Show(this, UserData.UpdatePassword(updatePass), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                Reset();
            }
            catch (DataGetException ex) 
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtMatKhauMoi.Text = string.Empty;
            txtMatKhauCu.Text = string.Empty;
            txtNhapLaiMatKhau.Text = string.Empty;
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}

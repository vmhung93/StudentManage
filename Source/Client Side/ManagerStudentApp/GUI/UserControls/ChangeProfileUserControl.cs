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
using ManagerStudentLib.Authentication;
using ManagerStudentApp.Exceptions;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class ChangeProfileUserControl : UserControl
    {
        User currentUser;

        public ChangeProfileUserControl()
        {
            InitializeComponent();
        }

        private void ChangeProfileUserControl_Load(object sender, EventArgs e)
        {
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            currentUser = AuthenticationService.GetInstance().GetCurrentUser();
            txtMaSo.Text = currentUser.BadgeId;
            txtQuyenHan.Text = currentUser.Role.Name;
            txtHoTen.Text = currentUser.UserInfo.Name;
            txtEmail.Text = currentUser.UserInfo.Email;
            txtNgaySinh.Text = currentUser.UserInfo.DateOfBirth.ToShortDateString();
            raBtnNam.Checked = ( currentUser.UserInfo.Gender == Gender.Male) ? true : false;
            txtDiaChi.Text = currentUser.UserInfo.Address;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadCurrentUserData();
        }

        private bool KiemTraHoTen(string hoTen)
        {
            // Kiem tra giua 2 chu chi co 1 khoang trang
            if (hoTen.IndexOf("  ") != -1) return false;
            // Kiem tra cac ky tu dau phai viet hoa
            string[] arr = hoTen.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                // Kiểm tra chữ cái đầu tiên là Hoa
                if (char.IsLower(arr[i][0]) == true) return false;
                // Kiểm tra các chữ còn lại là chữ thường
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (char.IsUpper(arr[i][j]) == true) return false;
                }
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraHoTen(txtHoTen.Text.Trim())) {
                    MessageBox.Show(this, "Họ tên phải viết hoa chữ cái đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show(this, "Địa chỉ không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                currentUser.UserInfo.Name = txtHoTen.Text.Trim();
                currentUser.UserInfo.Address = txtDiaChi.Text.Trim();
                currentUser.UserInfo.Gender = (raBtnNam.Checked) ? Gender.Male : Gender.Female;

                MessageBox.Show(this, AuthenticationService.GetInstance().UpdateUserInfo(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                AuthenticationService.GetInstance().ReloadUserInfo();
            }
            catch (DataGetException ex)
            {
                MessageBox.Show(this, ex.DataGetMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadCurrentUserData();
        }
    }
}

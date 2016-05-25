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
using ManagerStudentLib.Data;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class AddAccountUserControl : UserControl
    {
        List<RoleInfo> roles;
        public AddAccountUserControl()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            roles = AuthenticationData.GetAllRoles();
            cbbQuyen.Items.Clear();
            foreach (var role in roles)
            {
                cbbQuyen.Items.Add(role.Name);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CreateUser user = new CreateUser();

            user.RoleId = roles[cbbQuyen.SelectedIndex].Id;
            user.Password = txtMatKhau.Text;
            user.UserInfo = new UserInfo()
            {
                Email = txtEmail.Text,
                DateOfBirth = dateTimePicker1.Value,
                Address = txtDiaChi.Text,
                Name = txtHoTen.Text,
                Gender = raBtnNam.Checked == true ? Gender.Male : Gender.Female
            };
            int error = 0;
            var getUser = UserData.CreateUser(user,ref error);
            if (getUser != null && error == 0)
            {
                string str = "Thông tin tài khoản:\n";
                str += "\nMã tài khoản : " + getUser.BadgeId;
                str += "\nMật khẩu : " + user.Password;
                str += "\nEmail : " + user.UserInfo.Email;
                MessageBox.Show(this, "Chỉ chấp nhận điểm là số và 10 >= điểm >= 0", "Thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(this, "Email đã tồn tại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void AddAccountUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

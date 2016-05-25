using ManagerStudentApp.Exceptions;
using ManagerStudentApp.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text)) {
                MessageBox.Show(this, "Mã hoặc mật khẩu không được trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ManagerStudentLib.Authentication.AuthenticationService.GetInstance().Authenticate(textBoxUsername.Text, textBoxPassword.Text);
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show(this, ex.DataGetException.DataGetMessage, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser() != null)
            {
                ResetPassword();
                this.Hide();
                Form mainForm = new AppForm();
                mainForm.ShowDialog();
                this.Show();
            } 
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetPassword()
        {
            textBoxPassword.Text = string.Empty;
        }
    }
}

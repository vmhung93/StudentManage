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
            ManagerStudentLib.Authentication.AuthenticationService.GetInstance().Authenticate(textBoxUsername.Text, textBoxPassword.Text);
            if (ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser() != null)
            {
                this.Hide();
                Form mainForm = new AppForm();
                mainForm.ShowDialog();
                this.Close();
            } 
        }

    }
}

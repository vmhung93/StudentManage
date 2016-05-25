using ManagerStudentLib.Data;
using ManagerStudentLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void LoadInit()
        {
            textBoxHost.Text = ManagerStudentLib.Data.DataHelper.GetHost();
            textBoxDomain.Text = ManagerStudentLib.Data.DataHelper.GetDomain();
            numericUpDownTimeout.Value = ManagerStudentLib.Data.DataHelper.GetTimeOut();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxHost.Text) || String.IsNullOrWhiteSpace(textBoxDomain.Text))
            {
                MessageBox.Show(this.Owner, "Các giá trị không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ManagerStudentLib.Data.DataHelper.SetDataSource(textBoxHost.Text.Trim(), textBoxDomain.Text.Trim(), numericUpDownTimeout.Value);
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadInit();
        }

        private void btnInitDb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Mã số : " + ManagerStudentLib.Data.SystemConfigData.InitData()+"\nMật khẩu : 123x@X" , "Thành công",MessageBoxButtons.OK);
        }
    }
}
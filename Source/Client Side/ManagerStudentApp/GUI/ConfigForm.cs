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
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxHost.Text) || String.IsNullOrWhiteSpace(textBoxDomain.Text)) 
            {
                MessageBox.Show(this.Owner, "Các giá trị không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ManagerStudentLib.Data.DataHelper.SetDataSource(textBoxHost.Text.Trim(), textBoxDomain.Text.Trim());
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadInit();
        }
    }
}

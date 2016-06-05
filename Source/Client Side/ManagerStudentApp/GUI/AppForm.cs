using ManagerStudentApp.GUI;
using ManagerStudentApp.GUI.TabControls;
using ManagerStudentApp.GUI.TreeControls;
using ManagerStudentLib.Authentication;
using ManagerStudentLib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            InitImageIcons();
            TreeControlsHelper.GetInstance().Reset();
            TabControlsHelper.GetInstance().Reset();
            TabControlsHelper.GetInstance().SetTabControl(tabControl1);
            TabControlsHelper.GetInstance().SetImageList(imageList);
            TreeControlsHelper.GetInstance().BuildTreeNodeControls(treeViewControls, imageList);
        }

        private void InitImageIcons()
        {
            imageList.Images.Clear();
            imageList.Images.Add("userInfo", Properties.Resources.userInfo);
            imageList.Images.Add("password", Properties.Resources.password);
            imageList.Images.Add("student", Properties.Resources.student);
            imageList.Images.Add("account", Properties.Resources.account);
            imageList.Images.Add("adduser", Properties.Resources.adduser);
            imageList.Images.Add("class", Properties.Resources._class);
            imageList.Images.Add("list", Properties.Resources.list);
            imageList.Images.Add("plus", Properties.Resources.plus);
            imageList.Images.Add("report", Properties.Resources.report);
            imageList.Images.Add("score", Properties.Resources.score);
            imageList.Images.Add("subject", Properties.Resources.subject);
            imageList.Images.Add("settings", Properties.Resources.settings);
            imageList.Images.Add("profile", Properties.Resources.profile);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthenticationService.GetInstance().Logout();
            this.Close();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configForm = new ConfigForm();
            configForm.ShowDialog();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            SystemConfigService.GetInstance().ReLoadConfigs();
            string textMessage = "Xin chào, " ;
            textMessage += ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser().UserInfo.Name;
            textMessage += string.Format(" (Quyền hạn : {0})", ManagerStudentLib.Authentication.AuthenticationService.GetInstance().GetCurrentUser().Role.Level.ToString());
            lbName.Text = textMessage;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Manual.chm");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                Help.ShowHelp(this, Directory.GetCurrentDirectory() + "\\Manual.chm");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
﻿using ManagerStudentApp.GUI.TabControls;
using ManagerStudentApp.GUI.TreeControls;
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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            InitTreeControls();
        }

        private void InitTreeControls()
        {
            TabControlsHelper.GetInstance().SetTabControl(this.tabControl1);
            TreeControlsHelper.GetInstance().BuildTreeNodeControls(treeViewControls, imageTreeList);
            //this.tabControl1.SelectedTab = this.tabPage4;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
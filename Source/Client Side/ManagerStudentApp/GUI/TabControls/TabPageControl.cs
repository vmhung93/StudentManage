using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerStudentApp.GUI.TreeControls;
namespace ManagerStudentApp.GUI.TabControls
{
    public class TabPageControl : TabPage
    {
        public TreeNodeControl TreeNodeControl { get; set; }
        public TabPageControl(TreeNodeControl treeNodeControl)
        {
            this.TreeNodeControl = treeNodeControl;
            this.Name = TreeNodeControl.GetAction().ToString();
            this.Text = TreeControlsHelper.GetActionValue(TreeNodeControl.GetAction());
            this.Controls.Add(UserControls.UserControlFactory.GetUserControl(TreeNodeControl.GetAction()));
            this.AutoScroll = true;
        }

        public void ResetControl()
        {
            this.Controls[0].Dispose();
            this.Controls.Add(UserControls.UserControlFactory.GetUserControl(TreeNodeControl.GetAction()));
        }

    }
}

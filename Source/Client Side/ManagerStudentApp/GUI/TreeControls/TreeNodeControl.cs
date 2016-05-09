using ManagerStudentApp.GUI.TabControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI.TreeControls
{
    public enum TreeRootId {
        INFO,
        STUDENT,
        CLASS,
        SUBJECT,
        SCORE,
        REPORT,
        ACCOUNT,
        SETTING
    }
    public class TreeNodeControl : TreeNode
    {
        ControlAction action;
        public TreeNodeControl(string name, int imageIndex, int selectedImageIndex, TreeNode parrent) : base(name, imageIndex, selectedImageIndex)
        {
            if (parrent != null)
            {
                parrent.Nodes.Add(this);
            }
            action = ControlAction.NONE;
        }

        public TreeNodeControl SetAction(ControlAction action)
        {
            this.action = action;
            //Create a TabPage
            TabControlsHelper.GetInstance().RegisterTabPage(new TabPageControl(this));
            return this;
        }

        public ControlAction GetAction()
        {
            return action;
        }

        public TreeNodeControl()
        {
        }
    }
}

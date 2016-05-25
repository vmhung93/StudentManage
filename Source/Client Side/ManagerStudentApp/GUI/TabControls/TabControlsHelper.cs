using ManagerStudentApp.GUI.TreeControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI.TabControls
{
    public class TabControlsHelper
    {
        private static TabControlsHelper instance;
        private Dictionary<TreeControls.ControlAction, TabPageControl> dicTabs;
        private TabControl tabControl;
        //singleton
        public static TabControlsHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new TabControlsHelper();
            }
            return instance;
        }

        public void Reset()
        {
            dicTabs = new Dictionary<TreeControls.ControlAction, TabPageControl>();
        }

        public void SetTabControl(TabControl tabControl)
        {
            this.tabControl = tabControl;
            this.tabControl.TabPages.Clear();
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tabControl.Padding = new System.Drawing.Point(22, 3);
            this.tabControl.DrawItem += this.TabControlDrawItem;
            this.tabControl.MouseUp += this.TabControlMouseUp;
        }

        private void TabControlDrawItem(object sender, DrawItemEventArgs e)
        {
            var f = new Font(e.Font.FontFamily, 10f);
            
            e.Graphics.DrawString("x", f, Brushes.Black, e.Bounds.Right - 20, e.Bounds.Top + 5);
           // e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 5);
            e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 13, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void TabControlMouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl.TabPages.Count; i++)
            {
                var r = tabControl.GetTabRect(i);
                var closeButton = new Rectangle(r.Right - 18, r.Top + 5, 20, 18);
                if (closeButton.Contains(e.Location)) {
                    if (MessageBox.Show("Bạn thật muốn đóng tab này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
       

        public void SelectTab(TreeControls.ControlAction action) {
            TabPageControl tabPage;
            if (dicTabs.TryGetValue(action, out tabPage))
            {
                if (!tabControl.TabPages.Contains(tabPage))
                {
                    tabPage.ResetControl();
                    tabControl.TabPages.Add(tabPage);
                }
                tabControl.SelectedTab = tabPage;
            }
        }

        public void RegisterTabPage(TabPageControl tabPage)
        {
            this.dicTabs.Add(tabPage.TreeNodeControl.GetAction(), tabPage);
        }
    }
}

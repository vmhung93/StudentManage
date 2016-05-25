using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class ListAccountUserControl : UserControl
    {
        public ListAccountUserControl()
        {
            InitializeComponent();
        }

        private void ListAccountUserControl_Load(object sender, EventArgs e)
        {
            var list = ManagerStudentLib.Data.UserData.GetAllUser(true);
            int i = 1;
            foreach (var item in list)
            {
                lvTaiKhoan.Items.Add(new ListViewItem(new string[] { i.ToString(), item.BadgeId, item.UserInfo.Name, item.Role.Name, item.UserInfo.Email, item.UserInfo.Address }));
                i++;
            }
        }
    }
}

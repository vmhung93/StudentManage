using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerStudentLib.Service;
using ManagerStudentLib.Models;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class SettingUserControl : UserControl
    {
        public SettingUserControl()
        {
            InitializeComponent();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            SystemConfigService.GetInstance().SetValue(SystemConfigEnum.MinAge, numericMinAge.Value);
            SystemConfigService.GetInstance().SetValue(SystemConfigEnum.MaxAge, numericMaxAge.Value);
            SystemConfigService.GetInstance().SetValue(SystemConfigEnum.MaxNumberInClass, numericMaxNumberInClass.Value);
            SystemConfigService.GetInstance().SetValue(SystemConfigEnum.PassScore, numericPassScore.Value);
            bool isSuccessful = SystemConfigService.GetInstance().UpdateConfigs();
            if (isSuccessful) {
                MessageBox.Show(this, "Đã được cập nhật", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show(this, "Không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SystemConfigService.GetInstance().ReLoadConfigs();
                LoadSystemConfigs();
            }
        }

        private void SettingUserControl_Load(object sender, EventArgs e)
        {
            LoadSystemConfigs();
        }
        private void LoadSystemConfigs()
        {
            numericMinAge.Value = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MinAge);
            numericMaxAge.Value = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxAge);
            numericMaxNumberInClass.Value = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass);
            numericPassScore.Value = SystemConfigService.GetInstance().GetValue(SystemConfigEnum.PassScore);
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            LoadSystemConfigs();
        }
    }
}

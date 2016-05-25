using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Data;
using ManagerStudentLib.Models;
using ManagerStudentLib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp.GUI.UserControls
{
    public partial class AddStudentUserControl : UserControl
    {
        public AddStudentUserControl()
        {
            InitializeComponent();
        }

        private string GioiTinh = "Nam";

        private int currentAge = 0;

        private void raBtnNam_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nam";
        }

        private void raBtnNu_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nu";
        }

        private bool KiemTraHoTen(string hoTen)
        {
            // Kiem tra giua 2 chu chi co 1 khoang trang
            if (hoTen.IndexOf("  ") != -1) return false;
            // Kiem tra cac ky tu dau phai viet hoa
            string[] arr = hoTen.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                // Kiểm tra chữ cái đầu tiên là Hoa
                if (char.IsLower(arr[i][0]) == true) return false;
                // Kiểm tra các chữ còn lại là chữ thường
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (char.IsUpper(arr[i][j]) == true) return false;
                }
            }
            return true;
        }

        private bool KiemTraDienThoai(string dienThoai)
        {
            // Kiểm tra dãy số đúng 12 kí tự
            if (dienThoai.Length != 12) return false;

            string[] arr = dienThoai.Split('-');
            if (arr.Length != 3) return false; // Mặc định là 3 mảng

            if (arr[0].Length != 3 || arr[1].Length != 4 || arr[2].Length != 3) return false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (char.IsDigit(arr[i][j]) == false) return false;
                }
            }
            return true;
        }

        private bool KiemTraEmail(string email)
        {
            string match = "^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$";
            Regex reg = new Regex(match);
            if (reg.IsMatch(email) == false) return false;
            return true;
        }

        // Kiểm tra nhập liệu
        private string KiemTraNhapLieu()
        {
            string thongBao = "";

            if (!KiemTraHoTen(txtHoTen.Text))
                thongBao += "Họ tên không hợp lệ\n";
            if (!KiemTraEmail(txtEmail.Text))
                thongBao += "Email không hợp lệ\n";
            if (!CheckAge())
                thongBao += "Tuổi không hợp lệ\n";
            return thongBao;
        }

        private bool CheckAge()
        {
            int maxAge = (int)SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxAge);
            int minAge = (int)SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MinAge);
            if (currentAge < minAge || currentAge > maxAge)
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string thongBao = KiemTraNhapLieu();
            if (String.IsNullOrEmpty(thongBao))
            {
                try
                {
                }
                catch (DataGetException ex)
                {
                    MessageBox.Show(ex.Status + "\n" + ex.DataGetMessage);
                }
                
            }
            else
            {
                MessageBox.Show(thongBao);
            }
        }

        private void AddStudentUserControl_Load(object sender, EventArgs e)
        {
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndLoadAge();
        }

        private void CalculateAndLoadAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dtpNgaySinh.Value.Year;
            if (now < dtpNgaySinh.Value.AddYears(age)) age--;
            currentAge = age;
            txtTuoi.Text = currentAge.ToString();
        }
    }
}
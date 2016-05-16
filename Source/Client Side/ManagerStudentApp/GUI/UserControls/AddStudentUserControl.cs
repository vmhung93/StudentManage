using ManagerStudentLib.Data;
using ManagerStudentLib.Models;
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

        private void raBtnNam_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nam";
        }

        private void raBtnNu_CheckedChanged(object sender, EventArgs e)
        {
            GioiTinh = "Nu";
        }

        static public bool KiemTraHoTen(string hoTen)
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

        static public bool KiemTraDienThoai(string dienThoai)
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

        static public bool KiemTraEmail(string email)
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

            if (KiemTraHoTen(txtHoTen.Text) == false)
                thongBao += "Họ Tên Không Hợp Lệ\n";
            if (KiemTraEmail(txtEmail.Text) == false)
                thongBao += "Email Không Hợp Lệ\n";
            return thongBao;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string thongBao = KiemTraNhapLieu();
            if (thongBao == "")
            {
                string json = StudentData.AddStudent(new Student()
                {
                    ID = 1,
                    HoTen = txtHoTen.Text,
                    NgaySinh = Convert.ToDateTime(txtNgaySinh.Text),
                    GioiTinh = GioiTinh,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    IdLop = 1,
                });
                MessageBox.Show(json);
            }
            else
            {
                MessageBox.Show(thongBao);
            }
        }

        //private void txtEmail_Validating(object sender, CancelEventArgs e)
        //{
        //    var regex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //    if (!Regex.IsMatch(txtEmail.Text, regex))
        //    {
        //        ShowError("Fuck Minh");
        //    }
        //    else
        //    {
        //        ShowError(string.Empty);
        //    }
        //}

        //private void ShowError(string error)
        //{
        //    if (!string.IsNullOrEmpty(error))
        //    {
        //        StringBuilder strBuilder = new StringBuilder(lblValidation.Text);
        //        strBuilder.Append(error);

        //        lblValidation.Text = strBuilder.ToString();
        //    }
        //}

        //private void Validating_Common(object sender, CancelEventArgs e)
        //{
        //    private Control control = (Control)sender;
        //    StringBuilder strBuilder = new StringBuilder(lblValidation.Text);

        //    switch (control.Name)
        //    {
        //        case "txtHoTen":

        //            if (control.Text.Length > 5)
        //            {
        //                strBuilder.Append("Fuck Ho Ten");
        //            }

        //            else
        //            {
        //                strBuilder.Replace("Fuck Ho Ten", string.Empty);
        //            }

        //            break;

        //        case "txtEmail":
        //            var regex = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //            if (!Regex.IsMatch(txtEmail.Text, regex))
        //            {
        //                strBuilder.Append("Fuck Email");
        //            }
        //            else
        //            {
        //                strBuilder.Replace("Fuck Email", string.Empty);
        //            }

        //            break;

        //        default:
        //            break;
        //    }

        //    lblValidation.Text = strBuilder.ToString();
        //}
    }
}
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

        private List<ClassInfo> listClassInfo;
        private List<RoleInfo> roles;

        private Dictionary<string, int> dicClassNum = new Dictionary<string,int>();

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
                    string roleId = null;
                    string pass = "12345678";
                    foreach (var role in roles)
                    {
                        if (role.Level == UserRole.STUDENT)
                        {
                            roleId = role.Id;
                            break;
                        }
                    }
                    int error = 0;
                    bool result = false;
                    if (cbbLop.SelectedIndex == 0)
                    {
                        var stu = new CreateUser()
                        {
                            UserInfo = new CreateUserInfo()
                            {
                                Name = txtHoTen.Text,
                                Address = txtDiaChi.Text,
                                DateOfBirth = dtpNgaySinh.Value,
                                Email = txtEmail.Text,
                                Gender = raBtnNam.Checked == true ? Gender.Male : Gender.Female
                            },
                            RoleId = roleId,
                            Password = pass
                        };
                        var r = UserData.CreateUser(stu, ref error);
                        if(r != null && error == 0)
                        {
                            result = true;
                        }
                    }
                    else
                    {
                        int currentNumClass = 0;
                        dicClassNum.TryGetValue(listClassInfo[cbbLop.SelectedIndex - 1].Id, out currentNumClass);
                        if (currentNumClass >= (int)SystemConfigService.GetInstance().GetValue(SystemConfigEnum.MaxNumberInClass))
                        {
                            MessageBox.Show(this, "Lớp hiện tại chọn đã đủ sỉ số", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }


                        var stu = new CreateStudentInClass()
                        {
                            Student = new CreateUser()
                            {
                                UserInfo = new CreateUserInfo()
                                {
                                    Name = txtHoTen.Text,
                                    Address = txtDiaChi.Text,
                                    DateOfBirth = dtpNgaySinh.Value,
                                    Email = txtEmail.Text,
                                    Gender = raBtnNam.Checked == true ? Gender.Male : Gender.Female
                                },
                                RoleId = roleId,
                                Password = pass
                            },
                            ClassId = listClassInfo[cbbLop.SelectedIndex - 1].Id
                        };
                        result = ClassData.CreateStudentInClass(stu, ref error);
                    }
                    if (result == true && error == 0)
                    {
                        MessageBox.Show(this, "Thêm học sinh thành công", "Thành công", MessageBoxButtons.OK);
                        Reset();
                    }
                    else if (result == false && error == 1)
                    {
                        MessageBox.Show(this, "Email bị trùng", "Thất bại", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(this, "Thêm học sinh thất bại", "Thất bại", MessageBoxButtons.OK);
                    }
                }
                catch (DataGetException ex)
                {
                    MessageBox.Show(this, ex.Status + "\n" + ex.DataGetMessage, "Thất bại", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show(thongBao);
            }
        }

        private void AddStudentUserControl_Load(object sender, EventArgs e)
        {
            listClassInfo = ClassData.GetListClasses();
            roles = AuthenticationData.GetAllRoles();
            cbbLop.Items.Add("Chưa chọn");
            foreach (var c in listClassInfo)
            {
                cbbLop.Items.Add(c.Name);
            }
            cbbLop.SelectedIndex = 0;
            LoadData();
        }

        void Reset()
        {
            dtpNgaySinh.Value = DateTime.Now;
            txtHoTen.Text = string.Empty;
            raBtnNam.Checked = true;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbbLop.SelectedIndex = 0;
            LoadData();
        }

        void LoadData()
        {
            lvLop.Items.Clear();
            dicClassNum.Clear();
            foreach (var cl in listClassInfo)
            {
                var students = ClassData.GetInfoClassWithStudents(cl.Id);
                int count = students.Students.Count;
                dicClassNum.Add(cl.Id, count);
                lvLop.Items.Add(new ListViewItem(new string[] { students.Class.Name, count.ToString() }));
            }
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

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
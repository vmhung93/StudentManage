using ManagerStudentLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Dummy a mock user admin
            //User mockUser = new User();
            //mockUser.Username = "Adminstator";
           // mockUser.Role = Authentication.UserRole.ADMINSTRATOR;
            //Authentication.AuthenticationService.GetInstance().currentUser = mockUser;
            Application.Run(new LoginForm());
        }
    }
}

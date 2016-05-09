using ManagerStudentLib.Data;
using ManagerStudentLib.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Authentication
{
    public enum UserRole
    {
        ADMINSTRATOR = 5,
        EDUCATION_STAFF = 4,
        PRINCIPAL = 3,
        TEACHER = 2,
        STUDENT = 1
    }
   

    public class AuthenticationService
    {
        //after the authentication working this member will be private
        public User currentUser { get; set; }
        private static AuthenticationService instance;
        //singleton
        public static AuthenticationService GetInstance()
        {
            if (instance == null)
            {
                instance = new AuthenticationService();
            }
            return instance;
        }

        public void Authenticate(string username, string password) {
            currentUser = AuthenticationData.Authenticate(username, password);
        }

        public void Logout()
        {

        }

        public User GetCurrentUser()
        {
            return currentUser;
        }
    }
}

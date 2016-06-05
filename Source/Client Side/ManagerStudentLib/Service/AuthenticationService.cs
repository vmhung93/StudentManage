using ManagerStudentApp.Exceptions;
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
    public class AuthenticationService
    {
        private User currentUser;
        private Dictionary<UserRole, RoleInfo> roles;
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

        public void LoadRoles()
        {
            if (currentUser.Role.Level == UserRole.ADMINSTRATOR || currentUser.Role.Level == UserRole.EDUCATION_STAFF)
            {
                roles = new Dictionary<UserRole, RoleInfo>();
                var rls = AuthenticationData.GetAllRoles();
                foreach (RoleInfo r in rls)
                {
                    switch (r.Level)
                    {
                        case UserRole.ADMINSTRATOR:
                            roles.Add(UserRole.ADMINSTRATOR, r);
                            break;
                        case UserRole.EDUCATION_STAFF:
                            roles.Add(UserRole.EDUCATION_STAFF, r);
                            break;
                        case UserRole.PRINCIPAL:
                            roles.Add(UserRole.PRINCIPAL, r);
                            break;
                        case UserRole.STUDENT:
                            roles.Add(UserRole.STUDENT, r);
                            break;
                        case UserRole.TEACHER:
                            roles.Add(UserRole.TEACHER, r);
                            break;
                    }
                }
            }
        }

        public string GetRoleId(UserRole level)
        {
            RoleInfo role;
            if (roles.TryGetValue(level, out role))
            {
                return role.Id;
            }
            else
            {
                return "";
            }
        }

        public void Authenticate(string username, string password) {
            try 
            {
                currentUser = AuthenticationData.Authenticate(username, password);
            } catch (AuthenticationException ex) 
            {
                currentUser = null;
                throw ex;
            }
        }

        public void Logout()
        {
            AuthenticationData.Logout();
            currentUser = null;
        }

        public User GetCurrentUser()
        {
            return currentUser;
        }

        public string UpdateUserInfo()
        {
            return UserData.UpdateUserInfo(currentUser.UserInfo);
           
        }

        public void ReloadUserInfo()
        {
            currentUser.UserInfo = UserData.ReLoadUserInfo(currentUser.UserInfo.Id);
        }
    }
}

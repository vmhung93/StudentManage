using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Models;
namespace ManagerStudentLib.Data
{
    public class AuthenticationData
    {
        public static string SUB_DOMAIN = "login";

        public static User Authenticate(string userId, string password)
        {
            User user = null;
            try
            {
                var loginInfo = new LoginInfo()
                {
                    UserId = userId,
                    Password = password
                };
                var url = DataHelper.DATA_SOURCE + "/" + SUB_DOMAIN;
                var requestJsonData = JsonConvert.SerializeObject(loginInfo);
                //ResponseData response = DataHelper.PostJsonData(url, requestJsonData);
                //var jsonUser = response.JsonData;
                var jsonUser = "{ \"FullName\" : \"Admin\" , \"Role\" : 5,  \"Token\" : \"ABC\"}";
                user = JsonConvert.DeserializeObject<User>(jsonUser);
            }
            catch (DataGetException ex)
            {
                throw (new AuthenticationException(ex));
            }
            return user;
        }
    }
}

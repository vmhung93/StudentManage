using ManagerStudentApp.Exceptions;
using ManagerStudentLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Data
{
    public class AuthenticationData
    {
        public static string SUB_DOMAIN = "login";

        //Login
        public static AuthencatedInfo Authenticate(string userId, string password)
        {
            AuthencatedInfo info = null;
            try
            {
                var loginInfo = new LoginInfo()
                {
                    UserId = userId,
                    Password = password
                };
                var url = DataHelper.DATA_SOURCE + "/" + SUB_DOMAIN;
                // http://localhost:/api/login
                var requestJsonData = JsonConvert.SerializeObject(loginInfo);
                // {UserId : ádasd, Password : ádasdasd}
                //ResponseData response = DataHelper.PostJsonData(url, requestJsonData);
                //var jsonUser = response.JsonData;
                var jsonUser = "{ \"FullName\" : \"Admin\" , \"Role\" : 5,  \"Token\" : \"ABC\"}";
                info = JsonConvert.DeserializeObject<AuthencatedInfo>(jsonUser);
            }
            catch (DataGetException ex)
            {
                throw (new AuthenticationException(ex));
            }
            return info;
        }

        public static string testData() {
            string url = DataHelper.DATA_SOURCE + "/Values";
            ResponseData response = DataHelper.Get(url);
            return response.JsonData;
        }
    }
}
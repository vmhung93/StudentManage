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
    public class UserData
    {
        public static User CreateUser(CreateUser user,ref int error)
        {
            string url = DataHelper.DATA_SOURCE + "/User";
            string jsonData = JsonConvert.SerializeObject(user);
            ResponseData responseData = DataHelper.Post(url,jsonData);
            if (responseData.Status == Response.Success)
            {
                error = 0;
                return JsonConvert.DeserializeObject<User>(responseData.JsonData);
            }
            else
            {
                error = responseData.Status == Response.EmailIsExist ? 1 : 0;
            }
            return null;
        }

        public static List<User> GetAllUser(bool active)
        {
            string url = DataHelper.DATA_SOURCE + "/User/GetAll/"+active.ToString();
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<User>>(responseData.JsonData);
            }
            return new List<User>();
        }

        public static string UpdateUserInfo(UserInfo userInfo)
        {
            string url = DataHelper.DATA_SOURCE + "/UserInfo";
            string jsonData = JsonConvert.SerializeObject(userInfo);
            ResponseData responseData = DataHelper.Put(url, jsonData);
            return responseData.Message;
        }

        public static UserInfo ReLoadUserInfo(string userInfoId)
        {
            string url = DataHelper.DATA_SOURCE + "/UserInfo/" + userInfoId;
            ResponseData responseData = DataHelper.Get(url);
            return JsonConvert.DeserializeObject<UserInfo>(responseData.JsonData);
        }

        public static string UpdatePassword(PasswordInfo newPass) 
        {
            string url = DataHelper.DATA_SOURCE + "/User/ChangePassword";
            string jsonData = JsonConvert.SerializeObject(newPass);
            ResponseData responseData = DataHelper.Post(url, jsonData);
            return responseData.Message;
        }
    }
}

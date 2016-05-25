﻿using ManagerStudentLib.Models;
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

        public static string Logout() 
        {
            string url = DataHelper.DATA_SOURCE + "/Logout";
            ResponseData response = DataHelper.Post(url, "");
            return response.Message;
        }
    }
}
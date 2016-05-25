﻿using ManagerStudentApp.Exceptions;
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
                var loginInfo = new 
                {
                    BadgeId = userId,
                    Password = password
                };
                var url = DataHelper.DATA_SOURCE + "/" + SUB_DOMAIN;
                //http://localhost:/api/login
                var requestJsonData = JsonConvert.SerializeObject(loginInfo);
                // {UserId : ádasd, Password : ádasdasd}
                ResponseData response = DataHelper.Post(url, requestJsonData);
                var jsonUser = response.JsonData;
                //var jsonUser = "{ \"FullName\" : \"Admin\" , \"Role\" : 5,  \"Token\" : \"ABC\"}";
                var getInfo = JsonConvert.DeserializeObject<GetAuthencatedInfo>(jsonUser);

                info = new AuthencatedInfo();
                info.FullName = getInfo.UserInfo.Name;
                info.Role = getInfo.Role.Level;
                info.Token = getInfo.AccessToken.ToString();
                info.RoleId = getInfo.RoleId.ToString();
            }
            catch (DataGetException ex)
            {
                return null;
                throw (new AuthenticationException(ex));
            }
            return info;
        }

        public static List<RoleInfo> GetAllRoles()
        {
            string url = DataHelper.DATA_SOURCE + "/Role";
            ResponseData responseData = DataHelper.Get(url);
            if (responseData.Status == Response.Success)
            {
                return JsonConvert.DeserializeObject<List<RoleInfo>>(responseData.JsonData);
            }
            return new List<RoleInfo>();
        }
    }
}
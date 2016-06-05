﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class User
    {
        public int UserCode { get; set; }
        public string BadgeId { get; set; }
        public string UserName { get; set; }
        public UserInfo UserInfo { get; set; }
        public string Id { get; set; }
        public RoleInfo Role { get; set; }
        [JsonProperty("AccessToken")]
        public string Token { get; set; }
    }

    public class UserInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("Gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }
        public string Email { get; set; }
        [JsonProperty("Adress")]
        public string Address { get; set; }
    }

    public class CreateUserInfo
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("Gender")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }
        public string Email { get; set; }
        [JsonProperty("Adress")]
        public string Address { get; set; }
    }

    public class CreateUser
    {
        public string Password { get; set; }
        public string RoleId { get; set; }
        public CreateUserInfo UserInfo { get; set; }
    }

    public class CreateStudentInClass
    {
        public CreateUser Student { get; set; }
        public string ClassId { get; set; }
    }

    public class PasswordInfo 
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public enum Gender
    {
        Male=0,
        Female=1
    }
}

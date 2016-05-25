using ManagerStudentLib.Authentication;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class AuthencatedInfo
    {
        public string FullName { get; set; }
        [JsonProperty("Role")]
        public RoleInfo Role { get; set; }
        public string Token { get; set; }
        public string RoleId { get; set; }
        //public GetAuthencatedInfo AuthenInfo { get; set; }
    }

    public class GetAuthencatedInfo
    {
        public string Id { get; set; }

        public int UserCode { get; set; }

        public string UserName { get; set; }

        public Guid AccessToken { get; set; }

        public UserInfo UserInfo { get; set; }

        public Guid UserInfoId { get; set; }

        public RoleInfo Role { get; set; }

        public Guid RoleId { get; set; }
    }
}

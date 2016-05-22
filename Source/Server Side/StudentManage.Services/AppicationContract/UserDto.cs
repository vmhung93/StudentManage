using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class UserDto : BaseDto
    {
        public int UserCode { get; set; }
        
        public string UserName { get; set; }
        
        public string Password { get; set; }

        public Guid AccessToken { get; set; }

        public UserInfoDto UserInfo { get; set; }

        public Guid UserInfoId { get; set; }

        public RoleDto Role { get; set; }

        public Guid RoleId { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class UserDto : BaseDto
    {
        public int UserCode { get; set; }

        public string UserName { get; set; }

        public Guid AccessToken { get; set; }

        [Required]
        public UserInfoDto UserInfo { get; set; }

        public Guid UserInfoId { get; set; }

        public RoleDto Role { get; set; }

        [Required]
        public Guid RoleId { get; set; }
    }

    public class LoginDto
    {
        [Required]
        public string BadgeId { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class PasswordDto
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
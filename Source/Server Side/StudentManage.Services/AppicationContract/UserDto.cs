using System;

namespace StudentManage.Services.AppicationContract
{
    public class UserDto : BaseDto
    {
        public int UserCode { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Guid AccessToken { get; set; }
    }
}
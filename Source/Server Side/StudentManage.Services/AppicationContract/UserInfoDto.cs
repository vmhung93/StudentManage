using StudentManage.Common;
using System;

namespace StudentManage.Services.AppicationContract
{
    public class UserInfoDto : BaseDto
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }
    }
}
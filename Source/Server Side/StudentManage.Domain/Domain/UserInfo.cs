using StudentManage.Common;
using System;

namespace StudentManage.Domain.Domain
{
    public class UserInfo : DomainBase
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public string Adress { get; set; }
    }
}
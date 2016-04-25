using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class User : DomainBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserCode { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Guid AccessToken { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

        [ForeignKey("UserInfo")]
        public Guid UserInfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class User : DomainBase, ITraceable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserCode { get; set; }

        public string BadgeId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Guid AccessToken { get; set; }

        public DateTime ExpiredToken { get; set; }

        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public Guid UserInfoId { get; set; }

        [ForeignKey("UserInfoId")]
        public virtual UserInfo UserInfo { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }

        public Guid? ModifiedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public virtual User ModifiedByUser { get; set; }
    }
}
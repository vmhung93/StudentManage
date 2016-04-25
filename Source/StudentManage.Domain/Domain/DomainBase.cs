using StudentManage.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Domain.Domain
{
    public class DomainBase
    {
        [Key]
        public Guid Id { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        //public User CreatedBy { get; set; }

        //public User ModifiedBy { get; set; }
    }
}
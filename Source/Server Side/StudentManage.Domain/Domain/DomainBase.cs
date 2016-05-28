using StudentManage.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class DomainBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Status Status { get; set; }

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
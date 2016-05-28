using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class Courses : DomainBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        public string Name { get; set; }

        public Guid? DeanId { get; set; }

        [ForeignKey("DeanId")]
        public virtual User Dean { get; set; }
    }
}
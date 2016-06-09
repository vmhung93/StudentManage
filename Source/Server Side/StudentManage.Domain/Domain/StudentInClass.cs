using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class StudentInClass : DomainBase
    {
        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual User Student { get; set; }

        public int OrderNumber { get; set; }

        public Guid ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Class Class { get; set; }

        public Guid? PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual PositionInClass Position { get; set; }
    }
}
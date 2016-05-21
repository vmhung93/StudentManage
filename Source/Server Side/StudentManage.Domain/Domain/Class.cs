using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class Class : DomainBase, ITraceable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        public string Name { get; set; }

        public Guid? GradeId { get; set; }

        [ForeignKey("GradeId")]
        public virtual Grade Grade { get; set; }

        public Guid HomeroomTeacherId { get; set; }

        [ForeignKey("HomeroomTeacherId")]
        public virtual User HomeroomTeacher { get; set; }

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
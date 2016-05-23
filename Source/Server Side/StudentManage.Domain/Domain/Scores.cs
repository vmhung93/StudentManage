using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class Scores : DomainBase, ITraceable
    {
        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual User Student { get; set; }

        public Guid CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Courses Course { get; set; }

        public Guid SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public virtual Semester Semester { get; set; }

        public Guid ScoreTypeId { get; set; }

        [ForeignKey("ScoreTypeId")]
        public virtual ScoreType ScoreType { get; set; }

        public decimal Score { get; set; }

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
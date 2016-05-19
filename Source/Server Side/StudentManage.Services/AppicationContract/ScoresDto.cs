using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class ScoresDto : BaseDto
    {
        public Guid StudentId { get; set; }
        
        public virtual UserDto Student { get; set; }

        public Guid CourseId { get; set; }
        
        public virtual CoursesDto Course { get; set; }

        public Guid ScoreTypeId { get; set; }
        
        public virtual ScoreTypeDto ScoreType { get; set; }

        public decimal Score { get; set; }
    }
}
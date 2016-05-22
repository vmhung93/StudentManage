using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class ScoresDto : BaseDto
    {
        public Guid StudentId { get; set; }
        
        public UserDto Student { get; set; }

        public Guid CourseId { get; set; }
        
        public CoursesDto Course { get; set; }

        public Guid ScoreTypeId { get; set; }
        
        public ScoreTypeDto ScoreType { get; set; }

        public decimal Score { get; set; }
    }
}
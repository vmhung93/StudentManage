using System;
using System.Collections.Generic;
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

        public Guid SemesterId { get; set; }
        
        public SemesterDto Semester { get; set; }

        public decimal Score { get; set; }
    }

    public class GetScoreByClassCourseSemesterDto
    {
        public Guid ClassId { get; set; }

        public Guid CourseId { get; set; }

        public Guid SemesterId { get; set; }
    }

    public class StudentWithScoreDto
    {
        public UserDto Student { get; set; }

        public List<ScoresDto> ListScore { get; set; }
    }

    public class ScoreUpdateDto
    {
        public List<ScoresDto> ScoresAdd;
        public List<ScoresDto> ScoresUpdate;
        public List<Guid> ScoresDelete;
    }
}
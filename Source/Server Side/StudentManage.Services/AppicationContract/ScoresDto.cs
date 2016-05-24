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

    public class PostNameDto
    {
        public string Name { get; set; }
    }

        public class ScoreUpdateDto
    {
        public List<ScoresDto> ScoresAdd { get; set; }
        public List<ScoresDto> ScoresUpdate { get; set; }
        public List<Guid> ScoresDelete { get; set; }
    }
    
    public class SemesterCourseDto
    {
        public SemesterDto Semester { get; set; }
        public List<CourseScoreDto> CourseScores { get; set; }
    }

    public class StudentClassCourseScoreDto
    {
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        public List<SemesterCourseDto> SemesterCourses { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class SemesterDto : BaseDto
    {
        public int Code { get; set; }

        public string Name { get; set; }
    }

    public class CourseScoreDto
    {
        public CoursesDto Course { get; set; }
        public List<ScoresDto> Scores { get; set; }
    }

    public class StudentCourseDto
    {
        public UserDto Student { get; set; }
        public List<CourseScoreDto> CourseScores { get; set; }
    }

    public class SummarySemesterDto
    {
        public ClassDto Class;
        public List<StudentCourseDto> StudentCourses;
    }
}
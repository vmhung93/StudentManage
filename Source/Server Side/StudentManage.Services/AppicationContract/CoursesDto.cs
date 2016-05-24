using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class CoursesDto : BaseDto
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public Guid? DeanId { get; set; }
        
        public UserDto Dean { get; set; }
    }

    public class GetSummaryCourseDto
    {
        public Guid CourseId;
        public Guid SemesterId;
    }

    public class SummaryCourseDto
    {
        public ClassDto Class;
        public List<StudentWithScoreDto> StudentScore;
    }
}
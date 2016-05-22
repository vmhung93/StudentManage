using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class CoursesDto : BaseDto
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public Guid DeanId { get; set; }
        
        public UserDto Dean { get; set; }

        public Guid SemesterId { get; set; }
        
        public SemesterDto Semester { get; set; }
    }
}
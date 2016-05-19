using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class ClassDto : BaseDto
    {
        public int Code { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid GradeId { get; set; }
        
        public ClassDto Class { get; set; }

        public Guid HomeroomTeacherId { get; set; }
        
        public UserDto HomeroomTeacher { get; set; }
    }
}
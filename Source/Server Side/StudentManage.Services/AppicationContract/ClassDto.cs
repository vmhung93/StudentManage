using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class ClassDto : BaseDto
    {
        public int Code { get; set; }
        
        public string Name { get; set; }

        public Guid GradeId { get; set; }

        public Guid HomeroomTeacherId { get; set; }
        
        public UserDto HomeroomTeacher { get; set; }
    }

    public class ClassInfoDto
    {
        public List<UserDto> HomeroomTeacherdes { get; set; }

        public List<UserDto> Students { get; set; }

        public List<GradeDto> Grades { get; set; }
    }
}
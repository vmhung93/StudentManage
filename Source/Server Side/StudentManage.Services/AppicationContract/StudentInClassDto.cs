using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class StudentInClassDto : BaseDto
    {
        public Guid StudentId { get; set; }
        
        public UserDto Student { get; set; }

        public int OrderNumber { get; set; }

        public Guid ClassId { get; set; }
        
        public ClassDto Class { get; set; }

        public Guid PositionId { get; set; }
        
        public PositionInClassDto Position { get; set; }
    }

    public class ClassWithStudentDto
    {
        public ClassDto Class { get; set; }

        public List<Guid> StudentIds { get; set; }
    }

    public class ClassStudentInfoDto
    {
        public ClassDto Class { get; set; }

        public List<UserDto> Students { get; set; }
    }

    public class UpdateClassWithStudentsDto
    {
        public ClassDto Class { get; set; }
        public List<Guid> AddStudentIds { get; set; }
        public List<Guid> SubtractStudentIds { get; set; }
    }
}
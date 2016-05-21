using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class StudentInClassDto : BaseDto
    {
        public Guid StudentId { get; set; }
        
        public virtual UserDto Student { get; set; }

        public int OrderNumber { get; set; }

        public Guid ClassId { get; set; }
        
        public virtual ClassDto Class { get; set; }

        public Guid PositionId { get; set; }
        
        public PositionInClassDto Position { get; set; }
    }
}
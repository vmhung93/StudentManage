using StudentManage.Common;
using System;

namespace StudentManage.Services.AppicationContract
{
    public class RoleDto : BaseDto
    {
        public string Name { get; set; }

        public RoleLevel Level { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public UserDto CreatedByUser { get; set; }

        public UserDto ModifiedByUser { get; set; }
    }
}
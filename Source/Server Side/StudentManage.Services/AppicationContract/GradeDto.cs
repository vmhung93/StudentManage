using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Services.AppicationContract
{
    public class GradeDto : BaseDto
    {
        public int Code { get; set; }
        
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public UserDto CreatedByUser { get; set; }

        public Guid? ModifiedBy { get; set; }

        public UserDto ModifiedByUser { get; set; }
    }
}
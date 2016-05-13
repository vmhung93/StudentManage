using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Domain.Domain
{
    public interface ITraceable
    {
        DateTime CreatedDate { get; set; }

        DateTime ModifiedDate { get; set; }

        Guid? CreatedBy { get; set; }

        Guid? ModifiedBy { get; set; }
    }
}
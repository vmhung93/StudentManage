using System;

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
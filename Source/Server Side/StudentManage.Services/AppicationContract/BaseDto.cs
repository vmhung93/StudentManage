using StudentManage.Common;
using System;

namespace StudentManage.Services.AppicationContract
{
    public class BaseDto
    {
        public Guid Id { get; set; }

        public Status Status { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class SystemConfigDto : BaseDto
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
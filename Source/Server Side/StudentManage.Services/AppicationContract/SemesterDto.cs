using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class SemesterDto : BaseDto
    {
        public int Code { get; set; }

        public string Name { get; set; }
    }
}
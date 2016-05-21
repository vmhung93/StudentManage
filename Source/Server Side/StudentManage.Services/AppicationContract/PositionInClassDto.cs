using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class PositionInClassDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
    }
}
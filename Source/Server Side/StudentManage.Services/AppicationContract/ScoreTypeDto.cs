using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class ScoreTypeDto : BaseDto
    {
        public string Name { get; set; }

        public double Coefficient { get; set; }
    }
}
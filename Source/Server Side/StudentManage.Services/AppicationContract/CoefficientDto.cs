﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManage.Services.AppicationContract
{
    public class CoefficientDto : BaseDto
    {
        public int Code { get; set; }
        
        public string Name { get; set; }
    }
}
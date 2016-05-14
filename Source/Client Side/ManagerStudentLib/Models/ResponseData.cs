﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class ResponseData
    {
        public int Status { get; set; }
        public string Message { get; set; }
        [JsonProperty("data")]
        public string JsonData { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerStudentLib.Models
{
    public class ScoreInfo
    {
        public string Id { get; set; }

        public string StudentId { get; set; }

        public string CourseId { get; set; }

        public string ScoreTypeId { get; set; }

        public ScoreType ScoreType { get; set; }

        public string SemesterId { get; set; }

        public decimal Score { get; set; }
    } 

    public class ScoreType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Coefficient { get; set; }
    }

    public class StudentWithScore
    {
        public User Student { get; set; }
        public List<ScoreInfo> ListScore { get; set; }
    }

    public class UpdateStudentWithScore
    {
        public List<ScoreInfo> ScoresMerge;
        public List<string> ScoresDelete;
    }

    public class LoadScoreInfo
    {
        public string ClassId { get; set; }
        public string CourseId { get; set; }
        public string SemesterId { get; set; }
    }
}

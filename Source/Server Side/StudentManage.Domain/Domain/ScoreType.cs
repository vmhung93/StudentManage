using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class ScoreType : DomainBase
    {
        public string Name { get; set; }

        public double Coefficient { get; set; }
    }
}
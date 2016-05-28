using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class PositionInClass : DomainBase
    {
        public string Name { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManage.Domain.Domain
{
    public class SystemConfig : DomainBase, ITraceable
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
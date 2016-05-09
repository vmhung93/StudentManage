using StudentManage.Common;

namespace StudentManage.Domain.Domain
{
    public class Role : DomainBase
    {
        public string Name { get; set; }

        public RoleLevel Level { get; set; }
    }
}
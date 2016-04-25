using StudentManage.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Domain.DbContext
{
    public class StudentManageDbContext : System.Data.Entity.DbContext
    {
        public StudentManageDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<Role> Role { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}
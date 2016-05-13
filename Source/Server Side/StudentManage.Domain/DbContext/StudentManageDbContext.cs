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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentManageDbContext, Migrations.Configuration>());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Fluent API EF: https://msdn.microsoft.com/en-us/data/jj591617.aspx
            // Custom code first convention https://msdn.microsoft.com/en-us/data/jj819164

            modelBuilder.Entity<User>()
                .HasRequired<User>(u => u.CreatedByUser)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasRequired<User>(u => u.ModifiedByUser)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasRequired<Role>(u => u.Role)
                .WithMany();
        }
    }
}
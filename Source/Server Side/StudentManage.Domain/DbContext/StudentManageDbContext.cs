using StudentManage.Domain.Domain;
using System.Data.Entity;

namespace StudentManage.Domain.DbContext
{
    public class StudentManageDbContext : System.Data.Entity.DbContext
    {
        public StudentManageDbContext()
            : base("name=DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentManageDbContext, Migrations.Configuration>());
        }

        public DbSet<Class> Class { get; set; }

        public DbSet<Coefficient> Coefficient { get; set; }
        public DbSet<Courses> Courses { get; set; }

        public DbSet<Grade> Grade { get; set; }

        public DbSet<PositionInClass> PositionInClass { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Scores> Score { get; set; }

        public DbSet<ScoreType> ScoreType { get; set; }

        public DbSet<Semester> Semester { get; set; }

        public DbSet<StudentInClass> StudentInClass { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Fluent API EF: https://msdn.microsoft.com/en-us/data/jj591617.aspx
            // Custom code first convention https://msdn.microsoft.com/en-us/data/jj819164

            // User
            modelBuilder.Entity<User>()
                .HasRequired<User>(u => u.CreatedByUser)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasRequired<User>(u => u.ModifiedByUser)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasRequired<Role>(u => u.Role)
                .WithMany();

            modelBuilder.Entity<User>()
                .HasRequired<Role>(u => u.Role)
                .WithMany();

            // Class
            modelBuilder.Entity<Class>()
               .HasRequired<User>(c => c.CreatedByUser)
               .WithMany();

            modelBuilder.Entity<Class>()
                .HasRequired<User>(c => c.ModifiedByUser)
                .WithMany();

            modelBuilder.Entity<Class>()
               .HasRequired<User>(c => c.HomeroomTeacher)
               .WithMany();
        }
    }
}
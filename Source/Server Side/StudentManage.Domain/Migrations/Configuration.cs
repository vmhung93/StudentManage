namespace StudentManage.Domain.Migrations
{
    using Common;
    using Domain;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentManage.Domain.DbContext.StudentManageDbContext>
    {
        private bool hasPendingMigration = false;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            var migration = new DbMigrator(this);
            if (migration.GetPendingMigrations().Any())
            {
                hasPendingMigration = true;
            }
        }

        protected override void Seed(StudentManage.Domain.DbContext.StudentManageDbContext context)
        {
            // This method will be called after migrating to the latest version.
            // If don't have any pending migration then return
            if (!hasPendingMigration)
            {
                return;
            }

            #region ROLE

            // Super admin
            var saRole = new Role()
            {
                Name = "Administration",
                Level = RoleLevel.Adminstrator,
                Status = Status.Active,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            if (context.Role.FirstOrDefault(r => r.Name.Contains("Administration") && r.Level == RoleLevel.Adminstrator) == null)
            {
                context.Role.Add(saRole);
            }

            // Principal
            if (context.Role.FirstOrDefault(r => r.Name.Contains("Principal") && r.Level == RoleLevel.Principal) == null)
            {
                context.Role.Add(new Role()
                {
                    Name = "Principal",
                    Level = RoleLevel.Principal,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            // Student
            if (context.Role.FirstOrDefault(r => r.Name.Contains("Student") && r.Level == RoleLevel.Student) == null)
            {
                context.Role.Add(new Role()
                {
                    Name = "Student",
                    Level = RoleLevel.Student,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            // Teacher
            if (context.Role.FirstOrDefault(r => r.Name.Contains("Teacher") && r.Level == RoleLevel.Teacher) == null)
            {
                context.Role.Add(new Role()
                {
                    Name = "Teacher",
                    Level = RoleLevel.Teacher,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }
            context.SaveChanges();

            #endregion ROLE

            #region USER INFO

            var saUserInfo = new UserInfo()
            {
                Adress = "Address",
                DateOfBirth = new DateTime(1993, 1, 1),
                Email = "sa@studentmanage.com",
                Gender = Gender.Male,
                Name = "Super Admin",
                Status = Status.Active
            };

            if (context.UserInfo.FirstOrDefault(r => r.Email.Contains("sa@studentmanage.com")) == null)
            {
                context.UserInfo.Add(saUserInfo);
                context.SaveChanges();
            }

            #endregion USER INFO

            #region USER

            if (context.Users.FirstOrDefault(u => u.UserName.Contains("Super Admin") && u.Role.Level == RoleLevel.Adminstrator) == null)
            {
                // Seed default super admin
                context.Users.Add(
                new User()
                {
                    UserName = "Super Admin",
                    UserInfoId = saUserInfo.Id,
                    AccessToken = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Status = Status.Active,
                    ModifiedDate = DateTime.Now,
                    RoleId = saRole.Id,
                    Password = "123x@X"
                });

                context.SaveChanges();
            }

            #endregion USER
        }
    }
}
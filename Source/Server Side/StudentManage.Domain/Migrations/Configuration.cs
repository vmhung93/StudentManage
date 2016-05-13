namespace StudentManage.Domain.Migrations
{
    using Common;
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManage.Domain.DbContext.StudentManageDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManage.Domain.DbContext.StudentManageDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            // Seed default role
            var saRole = new Role()
            {
                Name = "Administration",
                Level = RoleLevel.Adminstrator,
                Status = Status.Active,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            context.Role.AddOrUpdate(
                r => r.Name,
                saRole,
                new Role()
                {
                    Name = "Principal",
                    Level = RoleLevel.Principal,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Role()
                {
                    Name = "Student",
                    Level = RoleLevel.Student,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Role()
                {
                    Name = "Teacher",
                    Level = RoleLevel.Teacher,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });

            context.SaveChanges();

            var saUserInfo = new UserInfo()
            {
                Adress = "Address SA",
                DateOfBirth = new DateTime(1993, 1, 1),
                Email = "sa@studentmanage.com",
                Gender = Gender.Male,
                Name = "Super Admin",
                Status = Status.Active
            };

            context.UserInfo.AddOrUpdate(ui => ui.Email, saUserInfo);
            context.SaveChanges();

            // Seed default super admin
            context.Users.AddOrUpdate(
                u => new { u.UserName, u.RoleId },
                new User()
                {
                    UserName = "sa",
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
    }
}
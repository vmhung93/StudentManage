namespace StudentManage.Domain.Migrations
{
    using Common;
    using Common.External_Lib;
    using Domain;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentManage.Domain.DbContext.StudentManageDbContext>
    {
        //private bool hasPendingMigration = false;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //var migration = new DbMigrator(this);
            //if (migration.GetPendingMigrations().Any())
            //{
            //    hasPendingMigration = true;
            //}
        }

        protected override void Seed(StudentManage.Domain.DbContext.StudentManageDbContext context)
        {
            // This method will be called after migrating to the latest version.
            // If don't have any pending migration then return
            //if (!hasPendingMigration)
            //{
            //    return;
            //}

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

            var saRoleEntity = context.Role.FirstOrDefault(r => r.Name.Contains("Administration") && r.Level == RoleLevel.Adminstrator);
            if (saRoleEntity == null)
            {
                context.Role.Add(saRole);
            }
            else {
                saRole = saRoleEntity;
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

            // Education staff
            if (context.Role.FirstOrDefault(r => r.Name.Contains("Education Staff") && r.Level == RoleLevel.Education_Staff) == null)
            {
                context.Role.Add(new Role()
                {
                    Name = "Education Staff",
                    Level = RoleLevel.Education_Staff,
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
            var teacherRole = new Role()
            {
                Name = "Teacher",
                Level = RoleLevel.Adminstrator,
                Status = Status.Active,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var teacherRoleEntity = context.Role.FirstOrDefault(r => r.Name.Contains("Teacher") && r.Level == RoleLevel.Teacher);
            if (teacherRoleEntity == null)
            {
                context.Role.Add(teacherRole);
            }
            else {
                teacherRole = teacherRoleEntity;
            }

            context.SaveChanges();

            #endregion ROLE

            #region USER INFO

            // SA user info
            var saUserInfo = new UserInfo()
            {
                Adress = "Address",
                DateOfBirth = new DateTime(1993, 1, 1),
                Email = "sa@studentmanage.com",
                Gender = Gender.Male,
                Name = "Super Admin",
                Status = Status.Active
            };

            var saUserInfoEntity = context.UserInfo.FirstOrDefault(r => r.Email.Contains("sa@studentmanage.com"));
            if (saUserInfoEntity == null)
            {
                context.UserInfo.Add(saUserInfo);
            }
            else
            {
                saUserInfo = saUserInfoEntity;
            }

            // Teacher user info
            var teacherUserInfo = new UserInfo()
            {
                Adress = "Address",
                DateOfBirth = new DateTime(1993, 1, 1),
                Email = "teacher@studentmanage.com",
                Gender = Gender.Male,
                Name = "Teacher",
                Status = Status.Active
            };

            var teacherUserInfoEntity = context.UserInfo.FirstOrDefault(r => r.Email.Contains("teacher@studentmanage.com"));
            if (teacherUserInfoEntity == null)
            {
                context.UserInfo.Add(teacherUserInfo);
            }
            else
            {
                teacherUserInfo = saUserInfoEntity;
            }

            context.SaveChanges();

            #endregion USER INFO

            #region USER

            // SA User
            var saUser = new User()
            {
                UserName = "Super Admin",
                UserInfoId = saUserInfo.Id,
                AccessToken = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Status = Status.Active,
                ModifiedDate = DateTime.Now,
                RoleId = saRole.Id,
                Password = "123x@X",
                ExpiredToken = DateTime.Now.AddYears(1)
            };

            var saUserEntity = context.Users.FirstOrDefault(u => u.UserName.Contains("Super Admin") && u.Role.Level == RoleLevel.Adminstrator);
            if (saUserEntity == null)
            {
                // Seed default super admin
                context.Users.Add(saUser);
                context.SaveChanges();

                // Generate badge id
                saUser.BadgeId = GenerateBadgeId.Generate(RoleLevel.Adminstrator, saUser.UserCode);

                // Hash password
                saUser.Password = Security.HashPassword(saUser.BadgeId, saUser.Password);

                context.SaveChanges();
            }
            else
            {
                saUser = saUserEntity;
            }

            // Teacher User
            var teacherUser = new User()
            {
                UserName = "Teacher",
                UserInfoId = teacherUserInfo.Id,
                AccessToken = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                Status = Status.Active,
                ModifiedDate = DateTime.Now,
                RoleId = teacherRole.Id,
                Password = "123x@X",
                ExpiredToken = DateTime.Now.AddYears(1)
            };

            var teacherUserEntity = context.Users.FirstOrDefault(u => u.UserName.Contains("Teacher") && u.Role.Level == RoleLevel.Teacher);
            if (teacherUserEntity == null)
            {
                // Seed default super admin
                context.Users.Add(teacherUser);
                context.SaveChanges();

                // Generate badge id
                teacherUser.BadgeId = GenerateBadgeId.Generate(RoleLevel.Teacher, teacherUser.UserCode);

                // Hash password
                teacherUser.Password = Security.HashPassword(teacherUser.BadgeId, teacherUser.Password);

                context.SaveChanges();
            }
            else
            {
                teacherUser = teacherUserEntity;
            }

            #endregion USER

            #region SYSTEM CONFIG

            // Min age
            string minAgeKey = SystemConfigEnum.MinAge.GetDescription();
            if (context.SystemConfig.FirstOrDefault(u => u.Name == minAgeKey) == null)
            {
                // Seed default super admin
                context.SystemConfig.Add(new SystemConfig()
                {
                    Name = minAgeKey,
                    Value = "15",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            // Max age
            string maxAgeKey = SystemConfigEnum.MaxAge.GetDescription();
            if (context.SystemConfig.FirstOrDefault(u => u.Name == maxAgeKey) == null)
            {
                // Seed default super admin
                context.SystemConfig.Add(new SystemConfig()
                {
                    Name = maxAgeKey,
                    Value = "20",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            // Pass score
            string passScore = SystemConfigEnum.PassScore.GetDescription();
            if (context.SystemConfig.FirstOrDefault(u => u.Name == passScore) == null)
            {
                // Seed default super admin
                context.SystemConfig.Add(new SystemConfig()
                {
                    Name = passScore,
                    Value = "5",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            // Maximum student in class
            string maxStudent = SystemConfigEnum.MaxNumberInClass.GetDescription();
            if (context.SystemConfig.FirstOrDefault(u => u.Name == maxStudent) == null)
            {
                // Seed default super admin
                context.SystemConfig.Add(new SystemConfig()
                {
                    Name = maxStudent,
                    Value = "40",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                });
            }

            context.SaveChanges();

            #endregion SYSTEM CONFIG

            #region GRADE

            // Grade 10
            var grade10 = new Grade()
            {
                Name = @"Khối 10",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var grade10Entity = context.Grade.FirstOrDefault(u => u.Name == @"Khối 10");
            if (grade10Entity == null)
            {
                context.Grade.Add(grade10);
            }
            else
            {
                grade10 = grade10Entity;
            }

            // Grade 11
            var grade11 = new Grade()
            {
                Name = @"Khối 11",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var grade11Entity = context.Grade.FirstOrDefault(u => u.Name == @"Khối 11");
            if (grade11Entity == null)
            {
                context.Grade.Add(grade11);
            }
            else
            {
                grade11 = grade11Entity;
            }

            // Grade 12
            var grade12 = new Grade()
            {
                Name = @"Khối 12",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var grade12Entity = context.Grade.FirstOrDefault(u => u.Name == @"Khối 12");
            if (grade12Entity == null)
            {
                context.Grade.Add(grade12);
            }
            else
            {
                grade12 = grade10Entity;
            }
            context.SaveChanges();

            #endregion GRADE

            #region CLASS

            // Class 10A1
            var class10A1 = new Class()
            {
                Name = @"Lớp 10A1",
                GradeId = grade10.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class10A1Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 10A1");
            if (class10A1Entity == null)
            {
                context.Class.Add(class10A1);
            }
            else
            {
                class10A1 = class10A1Entity;
            }

            // Class 10A2
            var class10A2 = new Class()
            {
                Name = @"Lớp 10A2",
                GradeId = grade10.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class10A2Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 10A2");
            if (class10A2Entity == null)
            {
                context.Class.Add(class10A2);
            }
            else
            {
                class10A2 = class10A2Entity;
            }

            // Class 10A3
            var class10A3 = new Class()
            {
                Name = @"Lớp 10A3",
                GradeId = grade10.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class10A3Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 10A3");
            if (class10A3Entity == null)
            {
                context.Class.Add(class10A3);
            }
            else
            {
                class10A3 = class10A3Entity;
            }

            // Class 10A4
            var class10A4 = new Class()
            {
                Name = @"Lớp 10A4",
                GradeId = grade10.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class10A4Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 10A4");
            if (class10A4Entity == null)
            {
                context.Class.Add(class10A4);
            }
            else
            {
                class10A4 = class10A4Entity;
            }

            // Class 11A1
            var class11A1 = new Class()
            {
                Name = @"Lớp 11A1",
                GradeId = grade11.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class11A1Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 11A1");
            if (class11A1Entity == null)
            {
                context.Class.Add(class11A1);
            }
            else
            {
                class11A1 = class11A1Entity;
            }

            // Class 11A2
            var class11A2 = new Class()
            {
                Name = @"Lớp 11A2",
                GradeId = grade11.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class11A2Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 11A2");
            if (class11A2Entity == null)
            {
                context.Class.Add(class11A2);
            }
            else
            {
                class11A2 = class11A2Entity;
            }

            // Class 11A3
            var class11A3 = new Class()
            {
                Name = @"Lớp 11A3",
                GradeId = grade11.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class11A3Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 11A3");
            if (class11A3Entity == null)
            {
                context.Class.Add(class11A3);
            }
            else
            {
                class11A3 = class11A3Entity;
            }

            // Class 12A1
            var class12A1 = new Class()
            {
                Name = @"Lớp 12A1",
                GradeId = grade12.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class12A1Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 12A1");
            if (class12A1Entity == null)
            {
                context.Class.Add(class12A1);
            }
            else
            {
                class12A1 = class12A1Entity;
            }

            // Class 12A2
            var class12A2 = new Class()
            {
                Name = @"Lớp 12A2",
                GradeId = grade10.Id,
                HomeroomTeacherId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var class12A2Entity = context.Class.FirstOrDefault(u => u.Name == @"Lớp 12A2");
            if (class12A2Entity == null)
            {
                context.Class.Add(class12A2);
            }
            else
            {
                class12A2 = class12A2Entity;
            }

            context.SaveChanges();

            #endregion CLASS

            #region SEMESTER

            // Semester 1
            var semeter1 = new Semester()
            {
                Name = @"Học kỳ 1",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var semeter1Entity = context.Semester.FirstOrDefault(u => u.Name == @"Học kỳ 1");
            if (semeter1Entity == null)
            {
                context.Semester.Add(semeter1);
            }

            // Semester 2
            var semeter2 = new Semester()
            {
                Name = @"Học kỳ 2",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var semeter2Entity = context.Semester.FirstOrDefault(u => u.Name == @"Học kỳ 2");
            if (semeter2Entity == null)
            {
                context.Semester.Add(semeter2);
            }

            context.SaveChanges();

            #endregion SEMESTER

            #region COURSES

            // Math
            var math = new Courses()
            {
                Name = @"Toán",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var mathEntity = context.Courses.FirstOrDefault(u => u.Name == @"Toán");
            if (mathEntity == null)
            {
                context.Courses.Add(math);
            }

            // Physical
            var physical = new Courses()
            {
                Name = @"Vật Lý",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var physicalEntity = context.Courses.FirstOrDefault(u => u.Name == @"Vật Lý");
            if (physicalEntity == null)
            {
                context.Courses.Add(physical);
            }

            // Chemistry
            var chemistry = new Courses()
            {
                Name = @"Hóa Học",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var chemistryEntity = context.Courses.FirstOrDefault(u => u.Name == @"Hóa Học");
            if (chemistryEntity == null)
            {
                context.Courses.Add(chemistry);
            }

            // Biological
            var biological = new Courses()
            {
                Name = @"Sinh Học",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var biologicalEntity = context.Courses.FirstOrDefault(u => u.Name == @"Sinh Học");
            if (biologicalEntity == null)
            {
                context.Courses.Add(biological);
            }

            // Historical
            var historical = new Courses()
            {
                Name = @"Lịch Sử",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var historyEntity = context.Courses.FirstOrDefault(u => u.Name == @"Lịch Sử");
            if (historyEntity == null)
            {
                context.Courses.Add(historical);
            }

            // Geography
            var geography = new Courses()
            {
                Name = @"Địa Lý",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var geographyEntity = context.Courses.FirstOrDefault(u => u.Name == @"Địa Lý");
            if (geographyEntity == null)
            {
                context.Courses.Add(geography);
            }

            // Literature
            var literature = new Courses()
            {
                Name = @"Văn Học",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var literatureEntity = context.Courses.FirstOrDefault(u => u.Name == @"Văn Học");
            if (literatureEntity == null)
            {
                context.Courses.Add(literature);
            }

            // Ethic
            var ethic = new Courses()
            {
                Name = @"Đạo đức",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var ethicEntity = context.Courses.FirstOrDefault(u => u.Name == @"Đạo đức");
            if (ethicEntity == null)
            {
                context.Courses.Add(ethic);
            }

            // Gymnastics
            var gymnastics = new Courses()
            {
                Name = @"Thể dục",
                DeanId = teacherUser.Id,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };

            var gymnasticsEntity = context.Courses.FirstOrDefault(u => u.Name == @"Thể dục");
            if (gymnasticsEntity == null)
            {
                context.Courses.Add(gymnastics);
            }

            context.SaveChanges();

            #endregion COURSES
        }
    }
}
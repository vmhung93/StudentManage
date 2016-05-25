using AutoMapper;
using StudentManage.Common;
using StudentManage.Common.External_Lib;
using StudentManage.Domain.DbContext;
using StudentManage.Domain.Domain;
using StudentManage.Services.AppicationContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage.Services.Services
{
    public interface IStudentInClassService
    {
        StudentInClassDto GetById(Guid studentInClassId);

        List<StudentInClassDto> GetAll();

        bool Create(StudentInClassDto studentInClassDto);

        bool Update(StudentInClassDto studentInClassDto);

        bool Delete(Guid studentInClassId);

        bool CreateClassWithStudent(ClassWithStudentDto classWithStudent);

        ClassStudentInfoDto GetClassStudentInfo(Guid classId);

        bool UpdateClassWithStudents(UpdateClassWithStudentsDto classWithStudentsDto);

        bool CreateStudentInClass(CreateStudentInClassDto createStudentInClssDto);

        bool CheckEmailIsExist(string email);
    }
    
    public class StudentInClassService : BaseService, IStudentInClassService
    {
        /// <summary>
        /// Create new studentInClass
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        public bool Create(StudentInClassDto studentInClassDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from studentInClass dto to studentInClass entity
                var studentInClassEntity = Mapper.Map<StudentInClass>(studentInClassDto);

                studentInClassEntity.CreatedDate = DateTime.Now;
                studentInClassEntity.ModifiedDate = DateTime.Now;

                // Add studentInClass to dbContext
                dbContext.StudentInClass.Add(studentInClassEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update studentInClass status is deleted
        /// </summary>
        /// <param name="studentInClassId"></param>
        /// <returns></returns>
        public bool Delete(Guid studentInClassId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get studentInClass by id
                var studentInClass = dbContext.StudentInClass.FirstOrDefault(g => g.Id == studentInClassId);

                if (studentInClass == null)
                {
                    return false;
                }

                // Update status from active to deleted
                studentInClass.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all studentInClass
        /// </summary>
        /// <returns></returns>
        public List<StudentInClassDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all studentInClass
                var studentInClasses = new List<StudentInClassDto>();
                var studentInClassEntity = dbContext.StudentInClass.ToList();

                if (!studentInClassEntity.Any())
                {
                    return null;
                }

                // Mapper from list studentInClass entity to studentInClass dto
                Mapper.Map<List<StudentInClass>, List<StudentInClassDto>>(studentInClassEntity, studentInClasses);

                return studentInClasses;
            }
        }

        /// <summary>
        /// Get studentInClass by studentInClass id
        /// </summary>
        /// <param name="studentInClassId"></param>
        /// <returns></returns>
        public StudentInClassDto GetById(Guid studentInClassId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get studentInClass by id
                var studentInClassEntity = dbContext.StudentInClass.FirstOrDefault(g => g.Id == studentInClassId);

                if (studentInClassEntity == null)
                {
                    return null;
                }

                var studentInClass = Mapper.Map<StudentInClassDto>(studentInClassEntity);

                return studentInClass;
            }
        }

        /// <summary>
        /// Update studentInClass info
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        public bool Update(StudentInClassDto studentInClassDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get studentInClass by id
                var studentInClassEntity = dbContext.StudentInClass.FirstOrDefault(g => g.Id == studentInClassDto.Id);

                if (studentInClassEntity == null)
                {
                    return false;
                }

                studentInClassEntity.OrderNumber = studentInClassDto.OrderNumber;
                studentInClassEntity.ClassId = studentInClassDto.ClassId;
                studentInClassEntity.PositionId = studentInClassDto.PositionId;
                studentInClassEntity.ModifiedDate = DateTime.Now;

                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Create class with student
        /// </summary>
        /// <param name="classWithStudent"></param>
        /// <returns></returns>
        public bool CreateClassWithStudent(ClassWithStudentDto classWithStudent)
        {
            bool result = false;

            using (var dbContext = new StudentManageDbContext())
            {
                var classEntity = Mapper.Map<Class>(classWithStudent.Class);
                classEntity.CreatedDate = DateTime.Now;
                classEntity.ModifiedDate = DateTime.Now;
                dbContext.Class.Add(classEntity);
                dbContext.SaveChanges();
                foreach (var student in classWithStudent.StudentIds)
                {
                    var studentEntity = new StudentInClass();
                    studentEntity.ClassId = classEntity.Id;
                    studentEntity.StudentId = student;
                    studentEntity.CreatedDate = DateTime.Now;
                    studentEntity.ModifiedDate = DateTime.Now;
                    studentEntity.Status = Common.Status.Active;
                    dbContext.StudentInClass.Add(studentEntity);
                }
                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public ClassStudentInfoDto GetClassStudentInfo(Guid classId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                var classEntity = dbContext.Class.FirstOrDefault(c => c.Id == classId);
                
                if (classEntity == null)
                {
                    return null;
                }

                var studentEntity = dbContext.StudentInClass.Where(s => s.ClassId == classId).Select(s => s.Student).ToList();
                
                var classDto = new ClassStudentInfoDto()
                {
                    Class = Mapper.Map<ClassDto>(classEntity),
                    Students = Mapper.Map<List<UserDto>>(studentEntity)
                };
                
                return classDto;
            }
        }

        /// <summary>
        /// Update student in and out class
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        public bool UpdateClassWithStudents(UpdateClassWithStudentsDto classWithStudentsDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                var classEntity = dbContext.Class.SingleOrDefault(c => c.Id == classWithStudentsDto.Class.Id);
                classEntity.Name = classWithStudentsDto.Class.Name;
                classEntity.HomeroomTeacherId = classWithStudentsDto.Class.HomeroomTeacherId;
                classEntity.GradeId = classWithStudentsDto.Class.GradeId;
                classEntity.Status = classWithStudentsDto.Class.Status;
                classEntity.ModifiedDate = DateTime.Now;
                dbContext.SaveChanges();

                foreach (var student in classWithStudentsDto.AddStudentIds)
                {
                    var studentEntity = dbContext.StudentInClass.SingleOrDefault(c => c.Status== Status.Active&& c.ClassId == classWithStudentsDto.Class.Id && c.StudentId == student);
                    if (studentEntity != null)
                    {
                        studentEntity.Status = Common.Status.Active;
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        studentEntity = new StudentInClass();
                        studentEntity.ClassId = classWithStudentsDto.Class.Id;
                        studentEntity.StudentId = student;
                        studentEntity.Status = Common.Status.Active;
                        dbContext.StudentInClass.Add(studentEntity);
                        dbContext.SaveChanges();
                    }
                }
                foreach (var student in classWithStudentsDto.SubtractStudentIds)
                {
                    var studentEntity = dbContext.StudentInClass.SingleOrDefault(c => c.Status == Status.Active && c.ClassId == classWithStudentsDto.Class.Id && c.StudentId == student && c.Status == Common.Status.Active);
                    if (studentEntity != null)
                    {
                        studentEntity.Status = Common.Status.Deleted;
                        dbContext.SaveChanges();
                    }
                }
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Update student in and out class
        /// </summary>
        /// <param name="studentInClassDto"></param>
        /// <returns></returns>
        public bool CreateStudentInClass(CreateStudentInClassDto createStudentInClassDto)
        {
            bool result = false;

            using (var dbContext = new StudentManageDbContext())
            {
                // Get user role
                var currentUserRole = dbContext.Role.FirstOrDefault(r => r.Id == createStudentInClassDto.Student.RoleId);

                // Using Mapper to map from user dto to user entity
                var userEntity = Mapper.Map<User>(createStudentInClassDto.Student);

                // Generate user access token
                userEntity.AccessToken = Guid.NewGuid();
                userEntity.ExpiredToken = DateTime.Now.AddDays(AppSettings.AccessTokenExpireTime);

                userEntity.CreatedDate = DateTime.Now;
                userEntity.ModifiedDate = DateTime.Now;

                // Add user to dbContext
                dbContext.Users.Add(userEntity);
                dbContext.SaveChanges();

                // Generate badge id
                userEntity.BadgeId = GenerateBadgeId.Generate(currentUserRole.Level, userEntity.UserCode);

                // Hash password
                userEntity.Password = Security.HashPassword(userEntity.BadgeId, userEntity.Password);

                // Update user name is badge id
                userEntity.UserName = userEntity.BadgeId;

                dbContext.SaveChanges();

                dbContext.StudentInClass.Add(new StudentInClass() { StudentId = userEntity.Id, ClassId = createStudentInClassDto.ClassId, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now });

                dbContext.SaveChanges();

                result = true;
            }
            return result;
        }

        public bool CheckEmailIsExist(string email)
        {
            bool result = false;

            using (var dbContext = new StudentManageDbContext())
            {
                // Get user by id
                result = dbContext.UserInfo.Any(u => u.Email.Contains(email));
            }

            return result;
        }
    }
}
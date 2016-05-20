using AutoMapper;
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
                studentInClassEntity.ModifiedDate = DateTime.Now;

                result = true;
            }

            return result;
        }
    }
}
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
    public interface ICoursesService
    {
        CoursesDto GetById(Guid coursesId);

        List<CoursesDto> GetAll();

        bool Create(CoursesDto CoursesDto);

        bool Update(CoursesDto CoursesDto);

        bool Delete(Guid coursesId);
    }

    public class CoursesService : BaseService, ICoursesService
    {
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        public bool Create(CoursesDto coursesDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from grade dto to grade entity
                var coursesEntity = Mapper.Map<Courses>(coursesDto);

                coursesEntity.CreatedDate = DateTime.Now;
                coursesEntity.ModifiedDate = DateTime.Now;

                // Add grade to dbContext
                dbContext.Courses.Add(coursesEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade status is deleted
        /// </summary>
        /// <param name="coursesId"></param>
        /// <returns></returns>
        public bool Delete(Guid coursesId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var courses = dbContext.Courses.FirstOrDefault(g => g.Id == coursesId);

                if (courses == null)
                {
                    return false;
                }

                // Update status from active to deleted
                courses.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all grade
        /// </summary>
        /// <returns></returns>
        public List<CoursesDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all grade
                var courses = new List<CoursesDto>();
                var coursesEntity = dbContext.Courses.ToList();

                if (!coursesEntity.Any())
                {
                    return null;
                }

                // Mapper from list grade entity to grade dto
                Mapper.Map<List<Courses>, List<CoursesDto>>(coursesEntity, courses);

                return courses;
            }
        }

        /// <summary>
        /// Get grade by grade id
        /// </summary>
        /// <param name="coursesId"></param>
        /// <returns></returns>
        public CoursesDto GetById(Guid coursesId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coursesEntity = dbContext.Courses.FirstOrDefault(g => g.Id == coursesId);

                if (coursesEntity == null)
                {
                    return null;
                }

                var courses = Mapper.Map<CoursesDto>(coursesEntity);

                return courses;
            }
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="coursesDto"></param>
        /// <returns></returns>
        public bool Update(CoursesDto CoursesDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var coursesEntity = dbContext.Courses.FirstOrDefault(g => g.Id == CoursesDto.Id);

                if (coursesEntity == null)
                {
                    return false;
                }

                coursesEntity.Name = CoursesDto.Name;
                coursesEntity.DeanId = CoursesDto.DeanId;
                coursesEntity.ModifiedDate = DateTime.Now;

                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }
    }
}
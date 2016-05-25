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
    public interface IGradeService
    {
        GradeDto GetById(Guid gradeId);

        List<GradeDto> GetAll();

        bool Create(GradeDto gradeDto);

        bool Update(GradeDto gradeDto);

        bool Delete(Guid gradeId);
    }

    public class GradeService : BaseService, IGradeService
    {
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="gradeDto"></param>
        /// <returns></returns>
        public bool Create(GradeDto gradeDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from grade dto to grade entity
                var userEntity = Mapper.Map<Grade>(gradeDto);

                userEntity.CreatedDate = DateTime.Now;
                userEntity.ModifiedDate = DateTime.Now;

                // Add grade to dbContext
                dbContext.Grade.Add(userEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update grade status is deleted
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public bool Delete(Guid gradeId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var grade = dbContext.Grade.FirstOrDefault(g => g.Id == gradeId);

                if (grade == null)
                {
                    return false;
                }

                // Update status from active to deleted
                grade.Status = Common.Status.Deleted;

                // Save change
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all grade
        /// </summary>
        /// <returns></returns>
        public List<GradeDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all grade
                var grades = new List<GradeDto>();
                var gradeEntity = dbContext.Grade.ToList();

                if (!gradeEntity.Any())
                {
                    return null;
                }

                // Mapper from list grade entity to grade dto
                Mapper.Map<List<Grade>, List<GradeDto>>(gradeEntity, grades);

                return grades;
            }
        }

        /// <summary>
        /// Get grade by grade id
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        public GradeDto GetById(Guid gradeId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var gradeEntity = dbContext.Grade.FirstOrDefault(g => g.Id == gradeId);

                if (gradeEntity == null)
                {
                    return null;
                }

                var grade = Mapper.Map<GradeDto>(gradeEntity);

                return grade;
            }
        }

        /// <summary>
        /// Update grade info
        /// </summary>
        /// <param name="gradeDto"></param>
        /// <returns></returns>
        public bool Update(GradeDto gradeDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get grade by id
                var gradeEntity = dbContext.Grade.FirstOrDefault(g => g.Id == gradeDto.Id);

                if (gradeEntity == null)
                {
                    return false;
                }

                gradeEntity.Name = gradeDto.Name;
                gradeEntity.ModifiedDate = DateTime.Now;

                // Save change
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }
    }
}
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
    public interface ISemesterService
    {
        SemesterDto GetById(Guid semesterId);

        List<SemesterDto> GetAll();

        bool Create(SemesterDto semesterDto);

        bool Update(SemesterDto semesterDto);

        bool Delete(Guid semesterId);
    }
    
    public class SemesterService : BaseService, ISemesterService
    {
        /// <summary>
        /// Create new semester
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        public bool Create(SemesterDto semesterDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from semester dto to semester entity
                var semesterEntity = Mapper.Map<Semester>(semesterDto);

                semesterEntity.CreatedDate = DateTime.Now;
                semesterEntity.ModifiedDate = DateTime.Now;

                // Add semester to dbContext
                dbContext.Semester.Add(semesterEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update semester status is deleted
        /// </summary>
        /// <param name="semesterId"></param>
        /// <returns></returns>
        public bool Delete(Guid semesterId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get semester by id
                var semester = dbContext.Semester.FirstOrDefault(g => g.Id == semesterId);

                if (semester == null)
                {
                    return false;
                }

                // Update status from active to deleted
                semester.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all semester
        /// </summary>
        /// <returns></returns>
        public List<SemesterDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all semester
                var semesters = new List<SemesterDto>();
                var semestersEntity = dbContext.Semester.ToList();

                if (!semestersEntity.Any())
                {
                    return null;
                }

                // Mapper from list semester entity to semester dto
                Mapper.Map<List<Semester>, List<SemesterDto>>(semestersEntity, semesters);

                return semesters;
            }
        }

        /// <summary>
        /// Get semester by semester id
        /// </summary>
        /// <param name="semesterId"></param>
        /// <returns></returns>
        public SemesterDto GetById(Guid semesterId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get semester by id
                var semesterEntity = dbContext.Semester.FirstOrDefault(g => g.Id == semesterId);

                if (semesterEntity == null)
                {
                    return null;
                }

                var semester = Mapper.Map<SemesterDto>(semesterEntity);

                return semester;
            }
        }

        /// <summary>
        /// Update semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        public bool Update(SemesterDto semesterDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get semester by id
                var semesterEntity = dbContext.Semester.FirstOrDefault(g => g.Id == semesterDto.Id);

                if (semesterEntity == null)
                {
                    return false;
                }

                semesterEntity.Name = semesterDto.Name;
                semesterEntity.ModifiedDate = DateTime.Now;

                result = true;
            }

            return result;
        }
    }
}
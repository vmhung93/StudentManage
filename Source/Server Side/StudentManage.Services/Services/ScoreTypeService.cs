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
    public interface IScoreTypeService
    {
        ScoreTypeDto GetById(Guid scoreTypeId);

        List<ScoreTypeDto> GetAll();

        bool Create(ScoreTypeDto scoreTypeDto);

        bool Update(ScoreTypeDto scoreTypeDto);

        bool Delete(Guid scoreTypeId);
    }

    public class ScoreTypeService : BaseService, IScoreTypeService
    {
        /// <summary>
        /// Create new scores
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        public bool Create(ScoreTypeDto scoreTypeDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from scores dto to scores entity
                var scoreTypesEntity = Mapper.Map<ScoreType>(scoreTypeDto);

                scoreTypesEntity.CreatedDate = DateTime.Now;
                scoreTypesEntity.ModifiedDate = DateTime.Now;

                // Add scores to dbContext
                dbContext.ScoreType.Add(scoreTypesEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update scores status is deleted
        /// </summary>
        /// <param name="scoreTypeId"></param>
        /// <returns></returns>
        public bool Delete(Guid scoreTypeId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scores = dbContext.ScoreType.FirstOrDefault(g => g.Id == scoreTypeId);

                if (scores == null)
                {
                    return false;
                }

                // Update status from active to deleted
                scores.Status = Common.Status.Deleted;

                // Save change to dbContext
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Get all scores
        /// </summary>
        /// <returns></returns>
        public List<ScoreTypeDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all scores
                var scoreTypes = new List<ScoreTypeDto>();
                var scoreTypesEntity = dbContext.ScoreType.ToList();

                if (!scoreTypesEntity.Any())
                {
                    return null;
                }

                // Mapper from list scores entity to scores dto
                Mapper.Map<List<ScoreType>, List<ScoreTypeDto>>(scoreTypesEntity, scoreTypes);

                return scoreTypes;
            }
        }

        /// <summary>
        /// Get scores by scores id
        /// </summary>
        /// <param name="scoreTypeId"></param>
        /// <returns></returns>
        public ScoreTypeDto GetById(Guid scoreTypeId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scoreTypesEntity = dbContext.ScoreType.FirstOrDefault(g => g.Id == scoreTypeId);

                if (scoreTypesEntity == null)
                {
                    return null;
                }

                var scores = Mapper.Map<ScoreTypeDto>(scoreTypesEntity);

                return scores;
            }
        }

        /// <summary>
        /// Update scores info
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        public bool Update(ScoreTypeDto scoreTypeDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scoreTypesEntity = dbContext.ScoreType.FirstOrDefault(g => g.Id == scoreTypeDto.Id);

                if (scoreTypesEntity == null)
                {
                    return false;
                }

                scoreTypesEntity.Name = scoreTypeDto.Name;
                scoreTypesEntity.ModifiedDate = DateTime.Now;

                dbContext.SaveChanges();
                result = true;
            }

            return result;
        }
    }
}
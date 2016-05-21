﻿using AutoMapper;
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
    public interface IScoresService
    {
        ScoresDto GetById(Guid scoresId);

        List<ScoresDto> GetAll();

        bool Create(ScoresDto scoresDto);

        bool Update(ScoresDto scoresDto);

        bool Delete(Guid scoresId);
    }
    
    public class ScoresService : BaseService, IScoresService
    {
        /// <summary>
        /// Create new scores
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        public bool Create(ScoresDto scoresDto)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Using Mapper to map from scores dto to scores entity
                var scoresEntity = Mapper.Map<Scores>(scoresDto);

                scoresEntity.CreatedDate = DateTime.Now;
                scoresEntity.ModifiedDate = DateTime.Now;

                // Add scores to dbContext
                dbContext.Score.Add(scoresEntity);
                dbContext.SaveChanges();

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Update scores status is deleted
        /// </summary>
        /// <param name="scoresId"></param>
        /// <returns></returns>
        public bool Delete(Guid scoresId)
        {
            bool result = false;

            // Create DBcontext object
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scores = dbContext.Score.FirstOrDefault(g => g.Id == scoresId);

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
        public List<ScoresDto> GetAll()
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get all scores
                var scores = new List<ScoresDto>();
                var scoresEntity = dbContext.Score.ToList();

                if (!scoresEntity.Any())
                {
                    return null;
                }

                // Mapper from list scores entity to scores dto
                Mapper.Map<List<Scores>, List<ScoresDto>>(scoresEntity, scores);

                return scores;
            }
        }

        /// <summary>
        /// Get scores by scores id
        /// </summary>
        /// <param name="scoresId"></param>
        /// <returns></returns>
        public ScoresDto GetById(Guid scoresId)
        {
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scoresEntity = dbContext.Score.FirstOrDefault(g => g.Id == scoresId);

                if (scoresEntity == null)
                {
                    return null;
                }

                var scores = Mapper.Map<ScoresDto>(scoresEntity);

                return scores;
            }
        }

        /// <summary>
        /// Update scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        public bool Update(ScoresDto scoresDto)
        {
            bool result = false;
            using (var dbContext = new StudentManageDbContext())
            {
                // Get scores by id
                var scoresEntity = dbContext.Score.FirstOrDefault(g => g.Id == scoresDto.Id);

                if (scoresEntity == null)
                {
                    return false;
                }

                scoresEntity.Score = scoresDto.Score;
                scoresEntity.ModifiedDate = DateTime.Now;

                result = true;
            }

            return result;
        }
    }
}
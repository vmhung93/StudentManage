using StudentManage.Common;
using StudentManage.DistributedService.Authorization;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    [CustomAuthorize]
    public class ScoresController : BaseApiController
    {
        private IScoresService ScoresService;

        public ScoresController(IScoresService scoresService)
        {
            this.ScoresService = scoresService;
        }

        /// <summary>
        /// Create new scores
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Scores")]
        public IHttpActionResult Create(ScoresDto scoresDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoresService.Create(scoresDto);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.CreateDataSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.CreateDataUnsuccessfully
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// Update scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Scores")]
        public IHttpActionResult Update(ScoresDto scoresDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoresService.Update(scoresDto);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.UpdateSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.UpdateUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// Delete scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteScores")]
        public IHttpActionResult Delete(BaseDto scoresDto)
        {
            try
            {
                if (scoresDto == null || scoresDto.Id == null || scoresDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = ScoresService.Delete(scoresDto.Id);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.DeleteUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetAll scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Scores")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<ScoresDto> result = ScoresService.GetAll();

                if (result.Count != 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Scores/{scoresId}")]
        public IHttpActionResult GetById(Guid scoresId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                ScoresDto result = ScoresService.GetById(scoresId);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Scores/GetScoreByClassCourseSemester")]
        public IHttpActionResult GetScoreByClassCourseSemester(GetScoreByClassCourseSemesterDto scoreDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<StudentWithScoreDto> result = ScoresService.GetScoreByClassCourseSemester(scoreDto);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.GetDataUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Scores/UpdateWithCreateScore")]
        public IHttpActionResult UpdateWithCreateScore(ScoreUpdateDto scoreDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoresService.UpdateWithCreateScore(scoreDto);

                if (result == true)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.UpdateSuccessful
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.UpdateUnsuccessful
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }

        /// <summary>
        /// GetById scores info
        /// </summary>
        /// <param name="studentName"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Scores/GetStudentCourseScore")]
        public IHttpActionResult GetStudentCourseScore(PostNameDto studentName)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<StudentClassCourseScoreDto> result = ScoresService.GetStudentCourseScore(studentName);

                if (result.Count > 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.GetDataSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.NoRecord
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = HttpStatusCode.InternalServerError,
                    Message = ResponseMessages.InternalServerError,
                    Error = ex.ToString()
                });
            }
        }
    }
}
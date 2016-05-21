using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
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
                    Message = ResponseMessages.InternalServerError
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
        [Route("api/Scores")]
        public IHttpActionResult Delete(Guid scoresId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoresService.Delete(scoresId);

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
        [HttpPost]
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
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = result
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
        /// GetById scores info
        /// </summary>
        /// <param name="scoresDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Scores")]
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
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = result
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
    }
}
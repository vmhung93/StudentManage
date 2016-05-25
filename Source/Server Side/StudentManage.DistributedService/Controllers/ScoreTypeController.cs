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
    public class ScoreTypeController : BaseApiController
    {
        private IScoreTypeService ScoreTypeService;

        public ScoreTypeController(IScoreTypeService scoreTypeService)
        {
            this.ScoreTypeService = scoreTypeService;
        }

        /// <summary>
        /// Create new scoreType
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/ScoreType")]
        public IHttpActionResult Create(ScoreTypeDto scoreTypeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoreTypeService.Create(scoreTypeDto);

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
        /// Update scoreType info
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/ScoreType")]
        public IHttpActionResult Update(ScoreTypeDto scoreTypeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = ScoreTypeService.Update(scoreTypeDto);

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
        /// Delete scoreType info
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteScoreType")]
        public IHttpActionResult Delete(BaseDto scoreTypeDto)
        {
            try
            {
                if (scoreTypeDto == null || scoreTypeDto.Id == null || scoreTypeDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = ScoreTypeService.Delete(scoreTypeDto.Id);

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
        /// GetAll scoreType info
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/ScoreType")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<ScoreTypeDto> result = ScoreTypeService.GetAll();

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
        /// GetById scoreType info
        /// </summary>
        /// <param name="scoreTypeDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/ScoreType/{scoreTypeId}")]
        public IHttpActionResult GetById(Guid scoreTypeId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                ScoreTypeDto result = ScoreTypeService.GetById(scoreTypeId);

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
    }
}
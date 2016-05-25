using StudentManage.Common;
using StudentManage.DistributedService.Authorization;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    [CustomAuthorize]
    public class GradeController : BaseApiController
    {
        private IGradeService GradeService;

        public GradeController(IGradeService gradeService)
        {
            this.GradeService = gradeService;
        }

        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="gradeDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Grade")]
        public IHttpActionResult Create(GradeDto gradeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = GradeService.Create(gradeDto);

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
        /// Update grade info
        /// </summary>
        /// <param name="gradeDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Grade")]
        public IHttpActionResult UpdateGradeInfo(GradeDto gradeDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = GradeService.Update(gradeDto);

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
        /// Delete grade by id
        /// </summary>
        /// <param name="gradeId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteGrade")]
        public IHttpActionResult Delete(BaseDto gradeDto)
        {
            try
            {
                if (gradeDto == null || gradeDto.Id == null || gradeDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = GradeService.Delete(gradeDto.Id);

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
        /// Get all grade, don't filter by status
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Grade")]
        public IHttpActionResult Get()
        {
            try
            {
                var result = GradeService.GetAll();

                if (result.Count > 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.CreateDataSuccessfully,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.OK,
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

        /// <summary>
        /// Get grade by id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Grade/{gradeId}")]
        public IHttpActionResult Get(Guid gradeId)
        {
            try
            {
                var result = GradeService.GetById(gradeId);

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
                    Status = HttpStatusCode.OK,
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
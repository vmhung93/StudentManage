using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class SemesterController : BaseApiController
    {
        private ISemesterService SemesterService;

        public SemesterController(ISemesterService semesterService)
        {
            this.SemesterService = semesterService;
        }

        /// <summary>
        /// Create new semester
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Semester")]
        public IHttpActionResult Create(SemesterDto semesterDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = SemesterService.Create(semesterDto);

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
        /// Update semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/Semester")]
        public IHttpActionResult Update(SemesterDto semesterDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = SemesterService.Update(semesterDto);

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
        /// Delete semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteSemester")]
        public IHttpActionResult Delete(BaseDto semesterDto)
        {
            try
            {
                if (semesterDto == null || semesterDto.Id == null || semesterDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = SemesterService.Delete(semesterDto.Id);

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
        /// GetAll semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Semester")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<SemesterDto> result = SemesterService.GetAll();

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
        /// GetById semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Semester/{semesterId}")]
        public IHttpActionResult GetById(Guid semesterId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                SemesterDto result = SemesterService.GetById(semesterId);

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
        /// GetById semester info
        /// </summary>
        /// <param name="semesterDto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Semester/GetSummarySemester/{semesterId}")]
        public IHttpActionResult GetSummarySemester(Guid semesterId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<SummarySemesterDto> result = SemesterService.GetSummarySemester(semesterId);

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
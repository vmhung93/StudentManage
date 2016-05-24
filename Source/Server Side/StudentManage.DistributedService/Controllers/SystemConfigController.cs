using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class SystemConfigController : BaseApiController
    {
        private ISystemConfigService SystemConfigService;

        public SystemConfigController(ISystemConfigService systemConfigService)
        {
            this.SystemConfigService = systemConfigService;
        }
        
        /// <summary>
        /// Create new grade
        /// </summary>
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/SystemConfig")]
        public IHttpActionResult Create(SystemConfigDto systemConfigDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = SystemConfigService.Create(systemConfigDto);

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
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/SystemConfig")]
        public IHttpActionResult Update(SystemConfigDto systemConfigDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = SystemConfigService.Update(systemConfigDto);

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
        /// <param name="systemConfigDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/DeleteSystemConfig")]
        public IHttpActionResult Delete(BaseDto systemConfigDto)
        {
            try
            {
                if (systemConfigDto == null || systemConfigDto.Id == null || systemConfigDto.Id == Guid.Empty)
                {
                    return BadRequest();
                }

                bool result = SystemConfigService.Delete(systemConfigDto.Id);

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
        [Route("api/SystemConfig")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = SystemConfigService.GetAll();

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
        [Route("api/SystemConfig/{systemConfigId}")]
        public IHttpActionResult Get(Guid systemConfigId)
        {
            try
            {
                var result = SystemConfigService.GetById(systemConfigId);

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
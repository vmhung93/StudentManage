using StudentManage.Common;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Collections.Generic;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class UserInfoController : BaseApiController
    {
        private IUserInfoService UserInfoService;

        public UserInfoController(IUserInfoService userInfoService)
        {
            this.UserInfoService = userInfoService;
        }

        /// <summary>
        /// Create new userInfo
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UserInfo")]
        public IHttpActionResult Create(UserInfoDto userInfoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = UserInfoService.Create(userInfoDto);

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
        /// Update userInfo info
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/UserInfo")]
        public IHttpActionResult Update(UserInfoDto userInfoDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = UserInfoService.Update(userInfoDto);

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
        /// Delete userInfo info
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UserInfo")]
        public IHttpActionResult Delete(Guid userInfoId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = UserInfoService.Delete(userInfoId);

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
        /// GetAll userInfo info
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UserInfo")]
        public IHttpActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                List<UserInfoDto> result = UserInfoService.GetAll();

                if (result.Count != 0)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
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
        /// GetById userInfo info
        /// </summary>
        /// <param name="userInfoDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/UserInfo/{userInfoId}")]
        public IHttpActionResult GetById(Guid userInfoId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                UserInfoDto result = UserInfoService.GetById(userInfoId);

                if (result != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.DeleteSuccessful,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(result)
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
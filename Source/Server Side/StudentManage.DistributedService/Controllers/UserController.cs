using StudentManage.Common;
using StudentManage.DistributedService.Authorization;
using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
using System.Net;
using System.Web.Http;

namespace StudentManage.DistributedService.Controllers
{
    public class UserController : BaseApiController
    {
        private IUserService UserService;

        public UserController(IUserService userService)
        {
            this.UserService = userService;
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/User")]
        [CustomAuthorize]
        public IHttpActionResult Create(UserDto userDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                // Check user email is exist or not
                if (UserService.CheckEmailIsExist(userDto.UserInfo.Email))
                {
                    return Json(new
                    {
                        Status = 198,
                        Message = ResponseMessages.EmailAlreadyExist
                    });
                }

                // Create new user
                bool result = UserService.Create(userDto);

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
        /// Logout user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Logout")]
        [CustomAuthorize]
        public IHttpActionResult Logout(BaseDto logoutDto)
        {
            try
            {
                // Logout
                var result = UserService.Logout(logoutDto.Id);

                if (result)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.LogoutSuccessfully
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.LogoutUnSuccessfully
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
        /// Login user, if login is successful then return user dto to client
        /// </summary>
        /// <param name="loginDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Login")]
        [CustomAuthorize(RequireAuthentication = false)]
        public IHttpActionResult Login(LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                // Login
                var userDto = UserService.Login(loginDto.BadgeId, loginDto.Password);

                if (userDto != null)
                {
                    return Json(new
                    {
                        Status = HttpStatusCode.OK,
                        Message = ResponseMessages.LoginSuccessfully,
                        Data = Newtonsoft.Json.JsonConvert.SerializeObject(userDto)
                    });
                }

                return Json(new
                {
                    Status = HttpStatusCode.BadRequest,
                    Message = ResponseMessages.LoginInvalidBadgeIdOrPassword
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
        /// Update user info
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/User/UserInfo")]
        [CustomAuthorize]
        public IHttpActionResult UpdateUserInfo(UserDto userDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                bool result = UserService.UpdateUserInfo(userDto);

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
    }
}
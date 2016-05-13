using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System;
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

        [HttpPost]
        [Route("api/Login")]
        public UserDto Login(UserDto userDto)
        {
            try
            {
                var result = UserService.Login(userDto.UserName, userDto.Password);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
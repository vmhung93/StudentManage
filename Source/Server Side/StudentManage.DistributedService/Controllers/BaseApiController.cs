using StudentManage.Services.AppicationContract;
using StudentManage.Services.Services;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace StudentManage.DistributedService.Controllers
{
    public class BaseApiController : ApiController
    {
        //protected readonly IUserService UserService;
        //public UserDto CurrentUser { get; private set; }

        //public BaseApiController(IUserService userService)
        //{
        //    this.UserService = userService;
        //}

        //protected override void Initialize(HttpControllerContext controllerContext)
        //{
        //    base.Initialize(controllerContext);

        //    if (!HttpContext.Current.Request.IsAuthenticated)
        //    {
        //        if (controllerContext.Request.Headers.Contains("Token"))
        //        {
        //            var tokens = controllerContext.Request.Headers.GetValues("Token");
        //            //var user = Services.Users.GetUserbyToken(tokens.First());

        //            //if (user == null)
        //            //{
        //            //    return;
        //            //}

        //            //CurrentUser = new ApplicationUser(user);
        //            //CurrentUser.Locations = Mapper.Map<List<LocationDto>, Collection<LocationDto>>(user.Locations.ToList());

        //            //var identity = new ClaimsIdentity(DefaultAuthenticationTypes.ExternalCookie);
        //            //identity.AddClaim(
        //            //    new Claim(ClaimTypes.Name, user.UserName)
        //            //);

        //            //HttpContext.Current.User = new ClaimsPrincipal(identity);
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        //var id = User.Identity.GetUserId<int>();
        //        //var user = Services.Users.GetUserById(id);
        //        //if (user == null)
        //        //{
        //        //    return;
        //        //}

        //        //CurrentUser = new ApplicationUser(user);
        //    }
        //}
    }
}
using StudentManage.Common;
using System.Web.Mvc;

namespace StudentManage.DistributedService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public FileResult DownloadFileSetup()
        {
            string linkDownload = AppSettings.LinkDownloadWinApp;

            if (string.IsNullOrEmpty(linkDownload))
            {
                return null;
            }

            string contentType = @"application/x-msdownload";

            return new FilePathResult(linkDownload, contentType)
            {
                FileDownloadName = @"StudentManageSetup.exe"
            };
        }
    }
}
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TPR.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TPRControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}
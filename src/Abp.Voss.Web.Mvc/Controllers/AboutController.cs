using Abp.AspNetCore.Mvc.Authorization;
using Abp.Voss.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Abp.Voss.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : VossControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
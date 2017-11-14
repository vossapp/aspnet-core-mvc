using Microsoft.AspNetCore.Antiforgery;
using Abp.Voss.Controllers;

namespace Abp.Voss.Web.Host.Controllers
{
    public class AntiForgeryController : VossControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

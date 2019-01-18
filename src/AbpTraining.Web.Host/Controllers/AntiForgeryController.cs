using Microsoft.AspNetCore.Antiforgery;
using AbpTraining.Controllers;

namespace AbpTraining.Web.Host.Controllers
{
    public class AntiForgeryController : AbpTrainingControllerBase
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

using Microsoft.AspNetCore.Antiforgery;
using InvoiceApp.Controllers;

namespace InvoiceApp.Web.Host.Controllers
{
    public class AntiForgeryController : InvoiceAppControllerBase
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

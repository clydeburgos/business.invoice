using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InvoiceApp.Controllers
{
    public abstract class InvoiceAppControllerBase: AbpController
    {
        protected InvoiceAppControllerBase()
        {
            LocalizationSourceName = InvoiceAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

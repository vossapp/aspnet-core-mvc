using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abp.Voss.Controllers
{
    public abstract class VossControllerBase: AbpController
    {
        protected VossControllerBase()
        {
            LocalizationSourceName = VossConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

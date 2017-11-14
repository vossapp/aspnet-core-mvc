using Abp.AspNetCore.Mvc.ViewComponents;

namespace Abp.Voss.Web.Views
{
    public abstract class VossViewComponent : AbpViewComponent
    {
        protected VossViewComponent()
        {
            LocalizationSourceName = VossConsts.LocalizationSourceName;
        }
    }
}
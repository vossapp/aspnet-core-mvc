using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Abp.Voss.Web.Views
{
    public abstract class VossRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected VossRazorPage()
        {
            LocalizationSourceName = VossConsts.LocalizationSourceName;
        }
    }
}

using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PlaygroundDemo.Web.Public.Views
{
    public abstract class PlaygroundDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PlaygroundDemoRazorPage()
        {
            LocalizationSourceName = PlaygroundDemoConsts.LocalizationSourceName;
        }
    }
}

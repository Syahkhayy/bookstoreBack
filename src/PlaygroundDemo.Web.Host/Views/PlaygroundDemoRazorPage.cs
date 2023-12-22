using Abp.AspNetCore.Mvc.Views;

namespace PlaygroundDemo.Web.Views
{
    public abstract class PlaygroundDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PlaygroundDemoRazorPage()
        {
            LocalizationSourceName = PlaygroundDemoConsts.LocalizationSourceName;
        }
    }
}

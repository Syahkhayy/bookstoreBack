using Abp.AspNetCore.Mvc.ViewComponents;

namespace PlaygroundDemo.Web.Public.Views
{
    public abstract class PlaygroundDemoViewComponent : AbpViewComponent
    {
        protected PlaygroundDemoViewComponent()
        {
            LocalizationSourceName = PlaygroundDemoConsts.LocalizationSourceName;
        }
    }
}
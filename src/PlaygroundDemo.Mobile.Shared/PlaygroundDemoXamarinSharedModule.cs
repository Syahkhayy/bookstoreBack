using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    [DependsOn(typeof(PlaygroundDemoClientModule), typeof(AbpAutoMapperModule))]
    public class PlaygroundDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoXamarinSharedModule).GetAssembly());
        }
    }
}
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    [DependsOn(typeof(PlaygroundDemoXamarinSharedModule))]
    public class PlaygroundDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoXamarinAndroidModule).GetAssembly());
        }
    }
}
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    [DependsOn(typeof(PlaygroundDemoXamarinSharedModule))]
    public class PlaygroundDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoXamarinIosModule).GetAssembly());
        }
    }
}
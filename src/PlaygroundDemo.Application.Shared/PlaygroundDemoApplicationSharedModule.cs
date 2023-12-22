using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    [DependsOn(typeof(PlaygroundDemoCoreSharedModule))]
    public class PlaygroundDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoApplicationSharedModule).GetAssembly());
        }
    }
}
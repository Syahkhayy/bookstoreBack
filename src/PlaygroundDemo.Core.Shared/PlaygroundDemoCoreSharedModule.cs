using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    public class PlaygroundDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoCoreSharedModule).GetAssembly());
        }
    }
}
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo
{
    public class PlaygroundDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoClientModule).GetAssembly());
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PlaygroundDemo.Startup
{
    [DependsOn(typeof(PlaygroundDemoCoreModule))]
    public class PlaygroundDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}
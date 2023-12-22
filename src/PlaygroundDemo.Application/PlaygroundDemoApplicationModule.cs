using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PlaygroundDemo.Authorization;

namespace PlaygroundDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(PlaygroundDemoApplicationSharedModule),
        typeof(PlaygroundDemoCoreModule)
        )]
    public class PlaygroundDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoApplicationModule).GetAssembly());
        }
    }
}
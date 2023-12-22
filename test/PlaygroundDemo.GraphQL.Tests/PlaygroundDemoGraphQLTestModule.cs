using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PlaygroundDemo.Configure;
using PlaygroundDemo.Startup;
using PlaygroundDemo.Test.Base;

namespace PlaygroundDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(PlaygroundDemoGraphQLModule),
        typeof(PlaygroundDemoTestBaseModule))]
    public class PlaygroundDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlaygroundDemoGraphQLTestModule).GetAssembly());
        }
    }
}
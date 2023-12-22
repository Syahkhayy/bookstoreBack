using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using PlaygroundDemo.Configuration;

namespace PlaygroundDemo.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(PlaygroundDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}

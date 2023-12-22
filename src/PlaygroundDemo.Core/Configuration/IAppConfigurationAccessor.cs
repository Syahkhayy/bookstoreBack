using Microsoft.Extensions.Configuration;

namespace PlaygroundDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

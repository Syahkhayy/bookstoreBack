using Abp.Modules;
using PlaygroundDemo.Test.Base;

namespace PlaygroundDemo.Tests
{
    [DependsOn(typeof(PlaygroundDemoTestBaseModule))]
    public class PlaygroundDemoTestModule : AbpModule
    {
       
    }
}

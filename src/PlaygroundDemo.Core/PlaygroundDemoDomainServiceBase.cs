using Abp.Domain.Services;

namespace PlaygroundDemo
{
    public abstract class PlaygroundDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PlaygroundDemoDomainServiceBase()
        {
            LocalizationSourceName = PlaygroundDemoConsts.LocalizationSourceName;
        }
    }
}

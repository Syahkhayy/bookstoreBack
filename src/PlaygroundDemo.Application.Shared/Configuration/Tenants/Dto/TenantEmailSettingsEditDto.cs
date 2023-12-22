using Abp.Auditing;
using PlaygroundDemo.Configuration.Dto;

namespace PlaygroundDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}
using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.Configuration.Tenants.Dto;

namespace PlaygroundDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

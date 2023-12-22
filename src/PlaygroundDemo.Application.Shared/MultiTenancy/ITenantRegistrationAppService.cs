using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.Editions.Dto;
using PlaygroundDemo.MultiTenancy.Dto;

namespace PlaygroundDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}
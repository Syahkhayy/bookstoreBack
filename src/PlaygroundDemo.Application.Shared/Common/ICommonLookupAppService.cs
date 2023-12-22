using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PlaygroundDemo.Common.Dto;
using PlaygroundDemo.Editions.Dto;

namespace PlaygroundDemo.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PlaygroundDemo.Authorization.Permissions.Dto;

namespace PlaygroundDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

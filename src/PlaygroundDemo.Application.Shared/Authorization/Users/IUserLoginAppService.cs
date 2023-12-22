using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PlaygroundDemo.Authorization.Users.Dto;

namespace PlaygroundDemo.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.Sessions.Dto;

namespace PlaygroundDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}

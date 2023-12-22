using System.Threading.Tasks;
using Abp.Application.Services;
using PlaygroundDemo.Install.Dto;

namespace PlaygroundDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}
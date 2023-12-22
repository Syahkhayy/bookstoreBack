using Abp.Application.Services;
using PlaygroundDemo.Dto;
using PlaygroundDemo.Logging.Dto;

namespace PlaygroundDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

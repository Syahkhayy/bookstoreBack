using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PlaygroundDemo.EntityFrameworkCore;

namespace PlaygroundDemo.HealthChecks
{
    public class PlaygroundDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public PlaygroundDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("PlaygroundDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("PlaygroundDemoDbContext could not connect to database"));
        }
    }
}

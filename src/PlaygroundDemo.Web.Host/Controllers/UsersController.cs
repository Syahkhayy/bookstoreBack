using Abp.AspNetCore.Mvc.Authorization;
using PlaygroundDemo.Authorization;
using PlaygroundDemo.Storage;
using Abp.BackgroundJobs;

namespace PlaygroundDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}
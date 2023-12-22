using Abp.Authorization;
using PlaygroundDemo.Authorization.Roles;
using PlaygroundDemo.Authorization.Users;

namespace PlaygroundDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

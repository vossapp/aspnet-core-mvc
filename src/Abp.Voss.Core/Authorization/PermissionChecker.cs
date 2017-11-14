using Abp.Authorization;
using Abp.Voss.Authorization.Roles;
using Abp.Voss.Authorization.Users;

namespace Abp.Voss.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

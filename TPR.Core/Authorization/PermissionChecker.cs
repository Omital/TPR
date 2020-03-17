using Abp.Authorization;
using TPR.Authorization.Roles;
using TPR.Authorization.Users;

namespace TPR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

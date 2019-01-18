using Abp.Authorization;
using AbpTraining.Authorization.Roles;
using AbpTraining.Authorization.Users;

namespace AbpTraining.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Abp.Authorization;
using InvoiceApp.Authorization.Roles;
using InvoiceApp.Authorization.Users;

namespace InvoiceApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

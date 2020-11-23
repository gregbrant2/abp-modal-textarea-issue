using abpForm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abpForm.Permissions
{
    public class abpFormPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(abpFormPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(abpFormPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<abpFormResource>(name);
        }
    }
}

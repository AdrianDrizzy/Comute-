using Co_Mute.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Co_Mute.Permissions;

public class Co_MutePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var co_MuteGroup = context.AddGroup(Co_MutePermissions.GroupName, L("Permission:Co_Mute"));

        var carpoolsPermission = co_MuteGroup.AddPermission(Co_MutePermissions.Carpools.Default, L("Permission:Carpools"));
        carpoolsPermission.AddChild(Co_MutePermissions.Carpools.Create, L("Permission:Carpools.Create"));
        carpoolsPermission.AddChild(Co_MutePermissions.Carpools.Edit, L("Permission:Carpools.Edit"));
        carpoolsPermission.AddChild(Co_MutePermissions.Carpools.Delete, L("Permission:Carpools.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Co_MutePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Co_MuteResource>(name);
    }
}

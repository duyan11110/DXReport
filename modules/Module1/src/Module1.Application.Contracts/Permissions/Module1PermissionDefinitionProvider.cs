using Module1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Module1.Permissions;

public class Module1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Module1Permissions.GroupName, L("Permission:Module1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Module1Resource>(name);
    }
}

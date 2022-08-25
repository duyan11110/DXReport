using Test.DXReport.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Test.DXReport.Permissions;

public class DXReportPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DXReportPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DXReportPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DXReportResource>(name);
    }
}

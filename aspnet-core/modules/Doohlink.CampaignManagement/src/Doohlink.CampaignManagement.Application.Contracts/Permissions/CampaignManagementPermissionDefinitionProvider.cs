using Doohlink.CampaignManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Doohlink.CampaignManagement.Permissions;

public class CampaignManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var campaignManagementGroup = context.AddGroup(CampaignManagementPermissions.GroupName, L("Permission:CampaignManagement"));
        var screensPermission = campaignManagementGroup.AddPermission(CampaignManagementPermissions.Screens.Default,
         L("Permission:Screens"),
         MultiTenancySides.Tenant);
        screensPermission.AddChild(CampaignManagementPermissions.Screens.Create,
            L("Permission:Create"),
            MultiTenancySides.Tenant);
        screensPermission.AddChild(CampaignManagementPermissions.Screens.Update,
            L("Permission:Edit"),
            MultiTenancySides.Tenant);
        screensPermission.AddChild(CampaignManagementPermissions.Screens.Delete,
            L("Permission:Delete"),
            MultiTenancySides.Tenant);
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CampaignManagementResource>(name);
    }
}

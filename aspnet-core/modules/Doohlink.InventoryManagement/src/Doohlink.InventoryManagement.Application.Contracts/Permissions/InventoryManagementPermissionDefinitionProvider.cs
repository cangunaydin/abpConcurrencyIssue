using Doohlink.InventoryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Doohlink.InventoryManagement.Permissions;

public class InventoryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var inventoryManagementGroup = context.AddGroup(InventoryManagementPermissions.GroupName, L("Permission:InventoryManagement"));

        var screensPermission = inventoryManagementGroup.AddPermission(InventoryManagementPermissions.Screens.Default, L("Permission:Screens"), MultiTenancySides.Tenant);
        screensPermission.AddChild(InventoryManagementPermissions.Screens.Create, L("Permission:Create"), MultiTenancySides.Tenant);
        screensPermission.AddChild(InventoryManagementPermissions.Screens.Update, L("Permission:Edit"), MultiTenancySides.Tenant);
        screensPermission.AddChild(InventoryManagementPermissions.Screens.Delete, L("Permission:Delete"), MultiTenancySides.Tenant);

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementResource>(name);
    }
}

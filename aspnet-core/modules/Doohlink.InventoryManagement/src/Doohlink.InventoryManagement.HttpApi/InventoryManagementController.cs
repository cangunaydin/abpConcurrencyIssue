using Doohlink.InventoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Doohlink.InventoryManagement;

public abstract class InventoryManagementController : AbpControllerBase
{
    protected InventoryManagementController()
    {
        LocalizationResource = typeof(InventoryManagementResource);
    }
}

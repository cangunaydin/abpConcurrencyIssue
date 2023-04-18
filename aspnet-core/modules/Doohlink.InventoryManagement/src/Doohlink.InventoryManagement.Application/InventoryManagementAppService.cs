using Doohlink.InventoryManagement.Localization;
using Volo.Abp.Application.Services;

namespace Doohlink.InventoryManagement;

public abstract class InventoryManagementAppService : ApplicationService
{
    protected InventoryManagementAppService()
    {
        LocalizationResource = typeof(InventoryManagementResource);
        ObjectMapperContext = typeof(InventoryManagementApplicationModule);
    }
}

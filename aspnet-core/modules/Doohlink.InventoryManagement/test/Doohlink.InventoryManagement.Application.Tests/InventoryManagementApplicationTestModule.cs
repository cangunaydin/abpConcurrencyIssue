using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(InventoryManagementApplicationModule),
    typeof(InventoryManagementDomainTestModule)
    )]
public class InventoryManagementApplicationTestModule : AbpModule
{

}

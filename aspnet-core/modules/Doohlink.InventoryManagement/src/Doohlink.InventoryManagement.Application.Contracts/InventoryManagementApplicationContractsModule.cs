using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(InventoryManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class InventoryManagementApplicationContractsModule : AbpModule
{

}

using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(InventoryManagementDomainSharedModule)
)]
public class InventoryManagementDomainModule : AbpModule
{

}

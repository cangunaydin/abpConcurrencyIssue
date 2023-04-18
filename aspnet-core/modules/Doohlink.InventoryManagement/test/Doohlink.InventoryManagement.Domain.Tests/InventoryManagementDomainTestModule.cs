using Doohlink.InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(InventoryManagementEntityFrameworkCoreTestModule)
    )]
public class InventoryManagementDomainTestModule : AbpModule
{

}

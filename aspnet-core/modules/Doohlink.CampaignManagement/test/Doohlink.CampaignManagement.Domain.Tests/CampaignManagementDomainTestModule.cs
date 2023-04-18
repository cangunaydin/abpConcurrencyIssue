using Doohlink.CampaignManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(CampaignManagementEntityFrameworkCoreTestModule)
    )]
public class CampaignManagementDomainTestModule : AbpModule
{

}

using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(CampaignManagementDomainSharedModule)
)]
public class CampaignManagementDomainModule : AbpModule
{

}

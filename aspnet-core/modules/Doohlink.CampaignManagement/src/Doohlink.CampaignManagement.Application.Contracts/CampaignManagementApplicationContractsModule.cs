using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(CampaignManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class CampaignManagementApplicationContractsModule : AbpModule
{

}

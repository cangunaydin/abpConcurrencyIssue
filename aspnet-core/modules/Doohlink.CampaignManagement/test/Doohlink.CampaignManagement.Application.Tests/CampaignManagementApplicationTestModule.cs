using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(CampaignManagementApplicationModule),
    typeof(CampaignManagementDomainTestModule)
    )]
public class CampaignManagementApplicationTestModule : AbpModule
{

}

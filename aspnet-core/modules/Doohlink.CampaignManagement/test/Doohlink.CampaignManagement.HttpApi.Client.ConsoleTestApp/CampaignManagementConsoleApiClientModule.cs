using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CampaignManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CampaignManagementConsoleApiClientModule : AbpModule
{

}

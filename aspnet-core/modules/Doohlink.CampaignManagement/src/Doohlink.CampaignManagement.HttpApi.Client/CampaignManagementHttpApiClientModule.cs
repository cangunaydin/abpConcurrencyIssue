using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(CampaignManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class CampaignManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(CampaignManagementApplicationContractsModule).Assembly,
            CampaignManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<CampaignManagementHttpApiClientModule>();
        });
    }
}

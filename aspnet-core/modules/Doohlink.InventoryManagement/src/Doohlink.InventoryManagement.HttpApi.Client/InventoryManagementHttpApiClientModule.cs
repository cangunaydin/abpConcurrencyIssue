using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(InventoryManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class InventoryManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(InventoryManagementApplicationContractsModule).Assembly,
            InventoryManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<InventoryManagementHttpApiClientModule>();
        });
    }
}

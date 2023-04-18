using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InventoryManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class InventoryManagementConsoleApiClientModule : AbpModule
{

}

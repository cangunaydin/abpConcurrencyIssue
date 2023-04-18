using Localization.Resources.AbpUi;
using Doohlink.InventoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Doohlink.InventoryManagement;

[DependsOn(
    typeof(InventoryManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class InventoryManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(InventoryManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<InventoryManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}

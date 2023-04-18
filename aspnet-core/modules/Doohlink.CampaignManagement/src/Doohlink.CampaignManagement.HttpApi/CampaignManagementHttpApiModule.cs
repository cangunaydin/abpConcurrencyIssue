using Localization.Resources.AbpUi;
using Doohlink.CampaignManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Doohlink.CampaignManagement;

[DependsOn(
    typeof(CampaignManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class CampaignManagementHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(CampaignManagementHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<CampaignManagementResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}

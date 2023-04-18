using Doohlink.CampaignManagement.EntityFrameworkCore.Screens;
using Doohlink.CampaignManagement.Screens;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Doohlink.CampaignManagement.EntityFrameworkCore;

[DependsOn(
    typeof(CampaignManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class CampaignManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<CampaignManagementDbContext>(options =>
        {
            options.AddDefaultRepositories();
            options.AddRepository<Screen, EfCoreScreenRepository>();
        });
    }
}

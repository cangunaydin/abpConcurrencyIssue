using Doohlink.InventoryManagement.EntityFrameworkCore.Screens;
using Doohlink.InventoryManagement.Screens;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Doohlink.InventoryManagement.EntityFrameworkCore;

[DependsOn(
    typeof(InventoryManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class InventoryManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<InventoryManagementDbContext>(options =>
        {
            options.AddDefaultRepositories();
            options.AddRepository<Screen, EfCoreScreenRepository>();
        });
    }
}


using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp.MultiTenancy;
using Volo.Saas.Editions;
using Volo.Saas.Tenants;

namespace Doohlink.Saas;
public class TenantDataSeeder : ITenantDataSeeder, ITransientDependency
{
    protected ITenantRepository TenantRepository;

    protected IEditionRepository EditionRepository;

    protected ITenantManager TenantManager;
    protected IGuidGenerator GuidGenerator { get; }
    protected ICurrentTenant CurrentTenant { get; }

    protected IIdentityDataSeeder IdentityDataSeeder;

    protected CampaignManagement.Screens.IScreenRepository CampaignScreenRepository;

    protected InventoryManagement.Screens.IScreenRepository InventoryScreenRepository;

    public TenantDataSeeder(
        ITenantRepository tenantRepository,
        IGuidGenerator guidGenerator,
        ICurrentTenant currentTenant,
        ITenantManager tenantManager,
        IEditionRepository editionRepository,
        IIdentityDataSeeder identityDataSeeder,
        CampaignManagement.Screens.IScreenRepository campaignScreenRepository,
        InventoryManagement.Screens.IScreenRepository inventoryScreenRepository)
    {
        TenantRepository = tenantRepository;
        GuidGenerator = guidGenerator;
        CurrentTenant = currentTenant;
        TenantManager = tenantManager;
        EditionRepository = editionRepository;
        IdentityDataSeeder = identityDataSeeder;
        CampaignScreenRepository = campaignScreenRepository;
        InventoryScreenRepository = inventoryScreenRepository;
    }

    public virtual async Task CreateTestTenantAsync()
    {
        if (CurrentTenant.IsAvailable)
        {
            return;
        }

        await AddTenantIfNotExistsAsync("Tribulus");
    }

    protected virtual async Task AddTenantIfNotExistsAsync(string tenantName)
    {
        if (await TenantRepository.FindByNameAsync(tenantName) != null)
        {
            return;
        }

        var tenant = await TenantManager.CreateAsync(tenantName, null);
        await TenantRepository.InsertAsync(
            tenant
        );
        await IdentityDataSeeder.SeedAsync("can@tribulusdevelopment.com", "123qwe", tenant.Id);
        using (CurrentTenant.Change(tenant.Id))
        {
            var screen1Id = Guid.Parse("AD16F9E2-BF39-43CF-AF69-47B7388EE9CD");
            var inventoryScreen = new InventoryManagement.Screens.Screen(screen1Id, "Screen 1", "00:00:00:00:00:00", tenant.Id);
            var campaignScreen = new CampaignManagement.Screens.Screen(screen1Id, 1920, 1080, tenant.Id);
            await InventoryScreenRepository.InsertAsync(inventoryScreen);
            await CampaignScreenRepository.InsertAsync(campaignScreen);

        }


    }
}

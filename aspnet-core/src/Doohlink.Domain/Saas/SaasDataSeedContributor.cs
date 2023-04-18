using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;
using Volo.Saas.Editions;

namespace Doohlink.Saas;

public class SaasDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IEditionDataSeeder _editionDataSeeder;
    private readonly ITenantDataSeeder _tenantDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public SaasDataSeedContributor(IEditionDataSeeder editionDataSeeder, ICurrentTenant currentTenant, ITenantDataSeeder tenantDataSeeder)
    {
        _editionDataSeeder = editionDataSeeder;
        _currentTenant = currentTenant;
        _tenantDataSeeder = tenantDataSeeder;
    }

    [UnitOfWork]
    public virtual async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _editionDataSeeder.CreateStandardEditionsAsync();
            await _tenantDataSeeder.CreateTestTenantAsync();
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Doohlink.Data;
using Volo.Abp.DependencyInjection;

namespace Doohlink.EntityFrameworkCore;

public class EntityFrameworkCoreDoohlinkDbSchemaMigrator
    : IDoohlinkDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDoohlinkDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DoohlinkDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DoohlinkDbContext>()
            .Database
            .MigrateAsync();

        await _serviceProvider
           .GetRequiredService<DoohlinkCampaignManagementDbContext>()
           .Database
           .MigrateAsync();

        await _serviceProvider
           .GetRequiredService<DoohlinkInventoryManagementDbContext>()
           .Database
           .MigrateAsync();
    }
}

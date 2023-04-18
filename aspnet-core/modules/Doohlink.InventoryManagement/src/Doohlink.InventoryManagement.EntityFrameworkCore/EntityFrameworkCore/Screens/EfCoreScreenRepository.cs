using Doohlink.InventoryManagement.Screens;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.InventoryManagement.EntityFrameworkCore.Screens;

public class EfCoreScreenRepository : EfCoreRepository<InventoryManagementDbContext, Screen, Guid>, IScreenRepository
{
    public EfCoreScreenRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(
        dbContextProvider)
    {
    }

    public async Task<List<Screen>> GetListAsync(
        string sorting = null,
        int skipCount = 0,
        int maxResultCount = int.MaxValue,
        string filter = null,
        CancellationToken cancellationToken = default)
    {
        var screenQueryable = await GetQueryableAsync();
        screenQueryable = screenQueryable
            .WhereIf(!string.IsNullOrWhiteSpace(filter),
                x => x.Name.ToLower().Contains(filter.ToLower()) ||
                     x.MacAddress.ToLower().Contains(filter.ToLower()));


        screenQueryable.PageBy(skipCount, maxResultCount);
        return await screenQueryable.ToListAsync(GetCancellationToken(cancellationToken));
    }

    public async Task<int> GetCountAsync(
        string filter = null,
        CancellationToken cancellationToken = default)
    {
        var screenQueryable = await GetQueryableAsync();
        screenQueryable = screenQueryable
            .WhereIf(!string.IsNullOrWhiteSpace(filter),
                x => x.Name.ToLower().Contains(filter.ToLower()) ||
                     x.MacAddress.ToLower().Contains(filter.ToLower()));
        return await screenQueryable.CountAsync(GetCancellationToken(cancellationToken));
    }
}


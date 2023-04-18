using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Volo.Abp.Domain.Repositories;

namespace Doohlink.InventoryManagement.Screens;

public interface IScreenRepository : IRepository<Screen, Guid>
{
    Task<List<Screen>> GetListAsync(
        string sorting = null,
        int skipCount = 0,
        int maxResultCount = int.MaxValue,
        string filter = null,
        CancellationToken cancellationToken = default
    );

    Task<int> GetCountAsync(
        string filter = null,
        CancellationToken cancellationToken = default
    );
}

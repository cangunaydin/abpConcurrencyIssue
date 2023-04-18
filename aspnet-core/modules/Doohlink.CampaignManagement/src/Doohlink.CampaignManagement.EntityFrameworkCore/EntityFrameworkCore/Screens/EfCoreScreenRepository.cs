using Doohlink.CampaignManagement.Screens;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.CampaignManagement.EntityFrameworkCore.Screens;

public class EfCoreScreenRepository : EfCoreRepository<ICampaignManagementDbContext, Screen, Guid>, IScreenRepository
{
    public EfCoreScreenRepository(IDbContextProvider<ICampaignManagementDbContext> dbContextProvider) : base(
        dbContextProvider)
    {
    }

}

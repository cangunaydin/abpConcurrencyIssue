using Doohlink.CampaignManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.CampaignManagement.EntityFrameworkCore;

[ConnectionStringName(CampaignManagementDbProperties.ConnectionStringName)]
public interface ICampaignManagementDbContext : IEfCoreDbContext
{
    DbSet<Screen> Screens { get; set; }
}

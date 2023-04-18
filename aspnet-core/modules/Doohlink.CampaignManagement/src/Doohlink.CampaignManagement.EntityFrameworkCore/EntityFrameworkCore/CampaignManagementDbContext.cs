using Doohlink.CampaignManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.CampaignManagement.EntityFrameworkCore;

[ConnectionStringName(CampaignManagementDbProperties.ConnectionStringName)]
public class CampaignManagementDbContext : AbpDbContext<CampaignManagementDbContext>, ICampaignManagementDbContext
{
    public DbSet<Screen> Screens { get; set; }

    public CampaignManagementDbContext(DbContextOptions<CampaignManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureCampaignManagement();
    }
}

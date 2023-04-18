using Doohlink.CampaignManagement;
using Doohlink.CampaignManagement.EntityFrameworkCore;
using Doohlink.CampaignManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.EntityFrameworkCore;

[ReplaceDbContext(typeof(ICampaignManagementDbContext))]
[ConnectionStringName(CampaignManagementDbProperties.ConnectionStringName)]
public class DoohlinkCampaignManagementDbContext :
    AbpDbContext<DoohlinkCampaignManagementDbContext>,ICampaignManagementDbContext
{

    public DbSet<Screen> Screens { get; set; }

    public DoohlinkCampaignManagementDbContext(DbContextOptions<DoohlinkCampaignManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);
        
        builder.ConfigureCampaignManagement();
    }


}
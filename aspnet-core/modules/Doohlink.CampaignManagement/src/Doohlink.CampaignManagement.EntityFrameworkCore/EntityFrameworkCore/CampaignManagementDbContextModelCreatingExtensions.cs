using Doohlink.CampaignManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Doohlink.CampaignManagement.EntityFrameworkCore;

public static class CampaignManagementDbContextModelCreatingExtensions
{
    public static void ConfigureCampaignManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Screen>(b =>
        {
            b.ToTable(CampaignManagementDbProperties.DbTablePrefix + "Screens",
                CampaignManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

          
            b.Property(o=>o.Width).HasColumnName(nameof(Screen.Width)).HasMaxLength(ScreenConsts.WidthMaxLength);
            b.Property(o=>o.Height).HasColumnName(nameof(Screen.Height)).HasMaxLength(ScreenConsts.HeightMaxLength);
            b.Property(o => o.AspectRatio).HasColumnName(nameof(Screen.AspectRatio));
            
        });
    }
}

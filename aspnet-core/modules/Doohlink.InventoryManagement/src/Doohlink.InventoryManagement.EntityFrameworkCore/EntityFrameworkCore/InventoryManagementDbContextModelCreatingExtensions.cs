using Doohlink.InventoryManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Doohlink.InventoryManagement.EntityFrameworkCore;

public static class InventoryManagementDbContextModelCreatingExtensions
{
    public static void ConfigureInventoryManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Screen>(b =>
        {
            b.ToTable(InventoryManagementDbProperties.DbTablePrefix + "Screens",
                InventoryManagementDbProperties.DbSchema);
            b.ConfigureByConvention();

            b.Property(s => s.Name).HasColumnName(nameof(Screen.Name)).HasMaxLength(ScreenConsts.MaxNameLength).IsRequired();

            b.Property(s => s.MacAddress).HasColumnName(nameof(Screen.MacAddress))
                .HasMaxLength(ScreenConsts.MaxMacAddressLength).IsRequired();


            b.HasIndex(s => s.MacAddress);
            b.HasIndex(s => s.Name);

        });
    }
}

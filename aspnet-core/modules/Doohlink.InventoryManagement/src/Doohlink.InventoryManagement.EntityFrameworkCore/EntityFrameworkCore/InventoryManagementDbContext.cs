using Doohlink.InventoryManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.InventoryManagement.EntityFrameworkCore;

[ConnectionStringName(InventoryManagementDbProperties.ConnectionStringName)]
public class InventoryManagementDbContext : AbpDbContext<InventoryManagementDbContext>, IInventoryManagementDbContext
{
    public DbSet<Screen> Screens { get; set; }

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureInventoryManagement();
    }
}

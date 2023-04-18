using Doohlink.InventoryManagement;
using Doohlink.InventoryManagement.EntityFrameworkCore;
using Doohlink.InventoryManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.EntityFrameworkCore;

[ReplaceDbContext(typeof(IInventoryManagementDbContext))]
[ConnectionStringName(InventoryManagementDbProperties.ConnectionStringName)]
public class DoohlinkInventoryManagementDbContext :
    AbpDbContext<DoohlinkInventoryManagementDbContext>,IInventoryManagementDbContext
{
    public DbSet<Screen> Screens { get; set; }
    public DoohlinkInventoryManagementDbContext(DbContextOptions<DoohlinkInventoryManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasPostgresExtension("postgis");
        builder.ConfigureInventoryManagement();
    }

   
}
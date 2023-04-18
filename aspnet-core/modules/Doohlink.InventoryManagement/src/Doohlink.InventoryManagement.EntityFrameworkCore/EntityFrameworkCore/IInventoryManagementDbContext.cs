using Doohlink.InventoryManagement.Screens;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Doohlink.InventoryManagement.EntityFrameworkCore;

[ConnectionStringName(InventoryManagementDbProperties.ConnectionStringName)]
public interface IInventoryManagementDbContext : IEfCoreDbContext
{
    public DbSet<Screen> Screens
    {
        get; set;
    }
}

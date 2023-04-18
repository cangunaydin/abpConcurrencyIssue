using System.Threading.Tasks;

namespace Doohlink.Data;

public interface IDoohlinkDbSchemaMigrator
{
    Task MigrateAsync();
}

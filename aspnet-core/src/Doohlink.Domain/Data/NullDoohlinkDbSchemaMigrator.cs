using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Doohlink.Data;

/* This is used if database provider does't define
 * IDoohlinkDbSchemaMigrator implementation.
 */
public class NullDoohlinkDbSchemaMigrator : IDoohlinkDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

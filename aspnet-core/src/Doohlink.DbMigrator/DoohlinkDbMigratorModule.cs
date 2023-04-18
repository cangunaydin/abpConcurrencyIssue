using Doohlink.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Doohlink.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DoohlinkEntityFrameworkCoreModule),
    typeof(DoohlinkApplicationContractsModule)
)]
public class DoohlinkDbMigratorModule : AbpModule
{

}

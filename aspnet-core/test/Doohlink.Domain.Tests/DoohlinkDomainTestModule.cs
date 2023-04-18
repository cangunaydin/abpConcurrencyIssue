using Doohlink.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Doohlink;

[DependsOn(
    typeof(DoohlinkEntityFrameworkCoreTestModule)
    )]
public class DoohlinkDomainTestModule : AbpModule
{

}

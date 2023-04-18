using Volo.Abp.Modularity;

namespace Doohlink;

[DependsOn(
    typeof(DoohlinkApplicationModule),
    typeof(DoohlinkDomainTestModule)
    )]
public class DoohlinkApplicationTestModule : AbpModule
{

}

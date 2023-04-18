using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Doohlink;

[Dependency(ReplaceServices = true)]
public class DoohlinkBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Doohlink";
}

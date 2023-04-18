using Doohlink.Localization;
using Volo.Abp.Application.Services;

namespace Doohlink;

/* Inherit your application services from this class.
 */
public abstract class DoohlinkAppService : ApplicationService
{
    protected DoohlinkAppService()
    {
        LocalizationResource = typeof(DoohlinkResource);
    }
}

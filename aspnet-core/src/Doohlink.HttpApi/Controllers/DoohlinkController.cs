using Doohlink.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Doohlink.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DoohlinkController : AbpControllerBase
{
    protected DoohlinkController()
    {
        LocalizationResource = typeof(DoohlinkResource);
    }
}

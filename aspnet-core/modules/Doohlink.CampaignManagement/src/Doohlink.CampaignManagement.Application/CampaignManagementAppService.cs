using Doohlink.CampaignManagement.Localization;
using Volo.Abp.Application.Services;

namespace Doohlink.CampaignManagement;

public abstract class CampaignManagementAppService : ApplicationService
{
    protected CampaignManagementAppService()
    {
        LocalizationResource = typeof(CampaignManagementResource);
        ObjectMapperContext = typeof(CampaignManagementApplicationModule);
    }
}

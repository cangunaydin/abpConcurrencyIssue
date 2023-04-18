using Doohlink.CampaignManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Doohlink.CampaignManagement;

public abstract class CampaignManagementController : AbpControllerBase
{
    protected CampaignManagementController()
    {
        LocalizationResource = typeof(CampaignManagementResource);
    }
}

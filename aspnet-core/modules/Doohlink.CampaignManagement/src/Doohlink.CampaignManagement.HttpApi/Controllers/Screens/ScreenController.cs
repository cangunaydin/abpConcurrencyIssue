using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Doohlink.CampaignManagement.Permissions;
using Doohlink.CampaignManagement.Screens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Doohlink.CampaignManagement.Controllers.Screens;

[RemoteService(Name = CampaignManagementRemoteServiceConsts.RemoteServiceName)]
[Area(CampaignManagementRemoteServiceConsts.ModuleName)]
[ControllerName("Screens")]
[Route("api/campaign-management/screen")]
[Authorize(CampaignManagementPermissions.Screens.Default)]
public class ScreenController : CampaignManagementController, IScreenControllerService
{
    private readonly IScreenAppService _screenAppService;

    public ScreenController(IScreenAppService screenAppService)
    {
        _screenAppService = screenAppService;
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<ScreenDto> GetAsync(Guid id)
    {
        return await _screenAppService.GetAsync(id);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doohlink.CampaignManagement.Permissions;

using Microsoft.AspNetCore.Authorization;

namespace Doohlink.CampaignManagement.Screens;

[Authorize(CampaignManagementPermissions.Screens.Default)]
public class ScreenAppService : CampaignManagementAppService, IScreenAppService
{
    private readonly IScreenRepository _screenRepository;

    public ScreenAppService(IScreenRepository screenRepository)
    {
        _screenRepository = screenRepository;
    }

    public async Task<ScreenDto> GetAsync(Guid id)
    {
        var screen = await _screenRepository.GetAsync(id);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(CampaignManagementPermissions.Screens.Create)]
    public async Task<ScreenDto> CreateAsync(Guid id, CreateScreenDto input)
    {
        var screen = new Screen(id, input.Width, input.Height, CurrentTenant.Id);

        await _screenRepository.InsertAsync(screen);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(CampaignManagementPermissions.Screens.Update)]
    public async Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input)
    {
        var screen = await _screenRepository.GetAsync(id);
        screen.UpdateResolution(input.Width, input.Height);
        await _screenRepository.UpdateAsync(screen);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(CampaignManagementPermissions.Screens.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        var screen = await _screenRepository.GetAsync(id);
        await _screenRepository.DeleteAsync(screen);
    }

}
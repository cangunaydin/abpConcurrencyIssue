using System;
using System.Threading.Tasks;
using Doohlink.InventoryManagement.Permissions;
using Doohlink.Screens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Doohlink.Controllers.Screens;

[RemoteService(Name = DoohlinkRemoteServiceConsts.RemoteServiceName)]
[Area(DoohlinkRemoteServiceConsts.ModuleName)]
[ControllerName("Screens")]
[Route("api/doohlink/screen")]
[Authorize(InventoryManagementPermissions.Screens.Default)]
public class ScreenController : DoohlinkController, IScreenAppService
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

    [HttpPost]
    [Authorize(InventoryManagementPermissions.Screens.Create)]
    public async Task<ScreenDto> CreateAsync(CreateScreenDto input)
    {
        return await _screenAppService.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id}")]
    [Authorize(InventoryManagementPermissions.Screens.Update)]
    public async Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input)
    {
        return await _screenAppService.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route("{id}")]
    [Authorize(InventoryManagementPermissions.Screens.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _screenAppService.DeleteAsync(id);
    }
}
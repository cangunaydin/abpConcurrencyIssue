using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Doohlink.InventoryManagement.Permissions;
using Doohlink.InventoryManagement.Screens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Doohlink.InventoryManagement.Controllers.Screens;

[RemoteService(Name = InventoryManagementRemoteServiceConsts.RemoteServiceName)]
[Area(InventoryManagementRemoteServiceConsts.ModuleName)]
[ControllerName("Screens")]
[Route("api/inventory-management/screen")]
[Authorize(InventoryManagementPermissions.Screens.Default)]
public class ScreenController : InventoryManagementController, IScreenControllerService
{
    private readonly IScreenAppService _screenAppService;

    public ScreenController(IScreenAppService screenAppService)
    {
        _screenAppService = screenAppService;
    }

    [HttpGet]
    public async Task<PagedResultDto<ScreenDto>> GetListAsync(ScreenListFilterDto input)
    {
        return await _screenAppService.GetListAsync(input);
    }

    [HttpGet]
    [Route("list-by-ids/{ids}")]
    public async Task<ListResultDto<ScreenDto>> GetListByIdsAsync(ICollection<Guid> ids)
    {
        return await _screenAppService.GetListByIdsAsync(ids);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ScreenDto> GetAsync(Guid id)
    {
        return await _screenAppService.GetAsync(id);
    }
}
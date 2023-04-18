using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doohlink.InventoryManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;

namespace Doohlink.InventoryManagement.Screens;

[Authorize(InventoryManagementPermissions.Screens.Default)]
public class ScreenAppService : InventoryManagementAppService, IScreenAppService
{
    private readonly IScreenRepository _screenRepository;

    public ScreenAppService(IScreenRepository screenRepository)
    {
        _screenRepository = screenRepository;
    }

    public async Task<PagedResultDto<ScreenDto>> GetListAsync(ScreenListFilterDto input)
    {
        var totalCount = await _screenRepository.GetCountAsync(
            input.Filter);
        var items = await _screenRepository.GetListAsync(input.Sorting,
            input.SkipCount,
            input.MaxResultCount,
            input.Filter);
        return new PagedResultDto<ScreenDto>(totalCount, ObjectMapper.Map<List<Screen>, List<ScreenDto>>(items));
    }

    public async Task<ListResultDto<ScreenDto>> GetListByIdsAsync(ICollection<Guid> ids)
    {
        var query = await _screenRepository.GetQueryableAsync();
        query = query.Where(screen => ids.Contains(screen.Id));

        var items = await AsyncExecuter.ToListAsync(query);
        return new ListResultDto<ScreenDto>(ObjectMapper.Map<List<Screen>, List<ScreenDto>>(items));
    }

    public async Task<ScreenDto> GetAsync(Guid id)
    {
        var screen = await _screenRepository.GetAsync(id);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(InventoryManagementPermissions.Screens.Create)]
    public async Task<ScreenDto> CreateAsync(Guid id, CreateScreenDto input)
    {
        var screen = new Screen(id, input.Name, input.MacAddress, CurrentTenant.Id);
      

        await _screenRepository.InsertAsync(screen);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(InventoryManagementPermissions.Screens.Update)]
    public async Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input)
    {
        var screen = await _screenRepository.GetAsync(id);
        screen.Update(input.Name, input.MacAddress);
        await _screenRepository.UpdateAsync(screen);
        return ObjectMapper.Map<Screen, ScreenDto>(screen);
    }

    [Authorize(InventoryManagementPermissions.Screens.Delete)]
    public async Task DeleteAsync(Guid id)
    {
        await _screenRepository.GetAsync(id);
        await _screenRepository.DeleteAsync(id);
    }
}
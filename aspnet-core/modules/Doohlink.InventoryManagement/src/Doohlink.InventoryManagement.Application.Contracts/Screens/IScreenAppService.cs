using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Doohlink.InventoryManagement.Screens;

public interface IScreenAppService : IScreenControllerService
{
    Task<ScreenDto> CreateAsync(Guid id, CreateScreenDto input);

    Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input);

    Task DeleteAsync(Guid id);
}

public interface IScreenControllerService : IApplicationService
{
    Task<PagedResultDto<ScreenDto>> GetListAsync(ScreenListFilterDto input);

    Task<ListResultDto<ScreenDto>> GetListByIdsAsync(ICollection<Guid> ids);
    Task<ScreenDto> GetAsync(Guid id);
}
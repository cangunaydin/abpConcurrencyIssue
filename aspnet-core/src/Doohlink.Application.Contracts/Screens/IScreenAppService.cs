using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Doohlink.Screens;

public interface IScreenAppService : IApplicationService
{
    Task<ScreenDto> GetAsync(Guid id);

    Task<ScreenDto> CreateAsync(CreateScreenDto input);

    Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input);

    Task DeleteAsync(Guid id);
}
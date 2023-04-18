using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Doohlink.CampaignManagement.Screens;

public interface IScreenAppService : IScreenControllerService
{
    Task<ScreenDto> CreateAsync(Guid id, CreateScreenDto input);

    Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input);

    Task DeleteAsync(Guid id);
}

public interface IScreenControllerService : IApplicationService
{
    Task<ScreenDto> GetAsync(Guid id);

}
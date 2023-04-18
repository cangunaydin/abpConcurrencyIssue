using System;
using System.Threading.Tasks;

namespace Doohlink.Screens;

public class ScreenAppService : DoohlinkAppService, IScreenAppService
{
    private readonly CampaignManagement.Screens.IScreenAppService _campaignScreenAppService;
    private readonly InventoryManagement.Screens.IScreenAppService _inventoryScreenAppService;

    public ScreenAppService(
        InventoryManagement.Screens.IScreenAppService inventoryScreenAppService,
        CampaignManagement.Screens.IScreenAppService campaignScreenAppService)
    {
        _inventoryScreenAppService = inventoryScreenAppService;
        _campaignScreenAppService = campaignScreenAppService;
    }

    public async Task<ScreenDto> GetAsync(Guid id)
    {
        var inventory = _inventoryScreenAppService.GetAsync(id);
        var campaign = _campaignScreenAppService.GetAsync(id);
        await Task.WhenAll(inventory, campaign);

        var screenDto = new ScreenDto();
        ObjectMapper.Map(inventory.Result, screenDto);
        ObjectMapper.Map(campaign.Result, screenDto);

        return screenDto;
    }

    public async Task<ScreenDto> CreateAsync(CreateScreenDto input)
    {
        var inventoryInput = ObjectMapper.Map<CreateScreenDto, InventoryManagement.Screens.CreateScreenDto>(input);
        var campaignInput = ObjectMapper.Map<CreateScreenDto, CampaignManagement.Screens.CreateScreenDto>(input);

        var id = GuidGenerator.Create();
        var inventory = _inventoryScreenAppService.CreateAsync(id, inventoryInput);
        var campaign = _campaignScreenAppService.CreateAsync(id, campaignInput);
        await Task.WhenAll(inventory, campaign);

        var screenDto = new ScreenDto();
        ObjectMapper.Map(inventory.Result, screenDto);
        ObjectMapper.Map(campaign.Result, screenDto);

        return screenDto;
    }

    public async Task<ScreenDto> UpdateAsync(Guid id, UpdateScreenDto input)
    {
        var inventoryInput = ObjectMapper.Map<UpdateScreenDto, InventoryManagement.Screens.UpdateScreenDto>(input);
        var campaignInput = ObjectMapper.Map<UpdateScreenDto, CampaignManagement.Screens.UpdateScreenDto>(input);

        var inventory = _inventoryScreenAppService.UpdateAsync(id, inventoryInput);
        var campaign = _campaignScreenAppService.UpdateAsync(id, campaignInput);
        await Task.WhenAll(inventory, campaign);

        var screenDto = new ScreenDto();
        ObjectMapper.Map(inventory.Result, screenDto);
        ObjectMapper.Map(campaign.Result, screenDto);

        return screenDto;
    }

    public async Task DeleteAsync(Guid id)
    {
        var inventory = _inventoryScreenAppService.DeleteAsync(id);
        var campaign = _campaignScreenAppService.DeleteAsync(id);
        await Task.WhenAll(inventory, campaign);
    }
}
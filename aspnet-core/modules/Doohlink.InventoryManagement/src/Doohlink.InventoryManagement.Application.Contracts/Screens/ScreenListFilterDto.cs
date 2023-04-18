using Volo.Abp.Application.Dtos;

namespace Doohlink.InventoryManagement.Screens;

public class ScreenListFilterDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }

}
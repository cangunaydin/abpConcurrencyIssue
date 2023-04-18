using System;
using Volo.Abp.Application.Dtos;

namespace Doohlink.InventoryManagement.Screens;

public class ScreenDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string MacAddress { get; set; }

}
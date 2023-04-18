using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Doohlink.CampaignManagement.Screens;

public class ScreenDto : EntityDto<Guid>
{
    public int Width { get; set; }

    public int Height { get; set; }

}
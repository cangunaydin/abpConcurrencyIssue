using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Doohlink.Screens;

public class ScreenDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string MacAddress { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Doohlink.InventoryManagement.Screens;
using JetBrains.Annotations;

namespace Doohlink.Screens;

public class UpdateScreenDto
{
    [Required]
    [StringLength(ScreenConsts.MaxNameLength, MinimumLength = ScreenConsts.MinNameLength)]
    public string Name { get; set; }

    [Required]
    public string MacAddress { get; set; }

    [Required]
    public int Width { get; set; }

    [Required]
    public int Height { get; set; }
}
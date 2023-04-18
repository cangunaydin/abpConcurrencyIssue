using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace Doohlink.InventoryManagement.Screens;

public class CreateScreenDto
{
    [Required]
    [StringLength(ScreenConsts.MaxNameLength, MinimumLength = ScreenConsts.MinNameLength)]
    public string Name { get; set; }

    [Required]
    public string MacAddress { get; set; }

}
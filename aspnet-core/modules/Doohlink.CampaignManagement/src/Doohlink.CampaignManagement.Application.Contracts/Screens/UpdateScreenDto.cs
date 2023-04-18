using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doohlink.CampaignManagement.Screens;

public class UpdateScreenDto
{
    [Required]
    public int Width { get; set; }

    [Required]
    public int Height { get; set; }
}
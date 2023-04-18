namespace Doohlink.CampaignManagement;

public static class CampaignManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "CampaignManagement";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "CampaignManagement";
}

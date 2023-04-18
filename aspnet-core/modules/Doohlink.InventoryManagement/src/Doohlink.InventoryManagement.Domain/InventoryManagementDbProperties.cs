namespace Doohlink.InventoryManagement;

public static class InventoryManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "InventoryManagement";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "InventoryManagement";
}

using Volo.Abp.Reflection;

namespace Doohlink.InventoryManagement.Permissions;

public class InventoryManagementPermissions
{
    public const string GroupName = "InventoryManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(InventoryManagementPermissions));
    }
    public static class Screens
    {
        public const string Default = GroupName + ".Screens";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";

    }
}

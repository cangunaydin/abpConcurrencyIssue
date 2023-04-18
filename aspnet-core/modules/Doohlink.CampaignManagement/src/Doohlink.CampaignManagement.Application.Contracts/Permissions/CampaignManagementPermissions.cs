using Volo.Abp.Reflection;

namespace Doohlink.CampaignManagement.Permissions;

public class CampaignManagementPermissions
{
    public const string GroupName = "CampaignManagement";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CampaignManagementPermissions));
    }
    public static class Screens
    {
        public const string Default = GroupName + ".Screens";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
}

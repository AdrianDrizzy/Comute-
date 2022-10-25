namespace Co_Mute.Permissions;

public static class Co_MutePermissions
{
    public const string GroupName = "Co_Mute";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Carpools
    {
        public const string Default = GroupName + ".Carpools";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}

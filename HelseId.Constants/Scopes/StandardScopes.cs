namespace HelseID.Constants.Scopes
{
    public static class StandardScopes
    {
        public const string OpenId = "openid";
        public const string Profile = "profile";
        public const string OfflineAccess = "offline_access";

        internal static string[] All { get; } = { OpenId, Profile, OfflineAccess };
    }
}
namespace HelseID.Constants.Scopes
{
    public static class StandardScopes
    {
        public const string OpenId = "openid";
        public const string Profile = "profile";

        public static string[] All { get; } = { OpenId, Profile };
    }
}
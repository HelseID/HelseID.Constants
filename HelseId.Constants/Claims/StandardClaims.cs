namespace HelseID.Constants.Claims
{
    public static class StandardClaims
    {
        public const string Name = "name";
        public const string FamilyName = "family_name";
        public const string GivenName = "given_name";
        public const string MiddleName = "middle_name";

        internal static string[] All { get; } = { Name, FamilyName, GivenName, MiddleName };
    }
}
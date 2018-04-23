namespace HelseID.Constants.Claims
{
    public static class HprClaims
    {
        private const string Prefix = HelseIdPrefix.Prefix + "hpr/";

        public const string HprNumber = Prefix + "hpr_number";

        public static string[] All { get; } = { HprNumber };
    }
}
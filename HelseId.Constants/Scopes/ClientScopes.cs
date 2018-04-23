namespace HelseID.Constants.Scopes
{
    public class ClientScopes
    {
        private const string Prefix = HelseIdPrefix.Prefix + "client/";

        public const string Dcr = Prefix + "dcr";
        public const string Kj = Prefix + "kj";
        // public const string StsConfigurationAdmin = Prefix + "sts_configuration_admin";

        internal static string[] All { get; } = { Dcr, Kj };
    }
}
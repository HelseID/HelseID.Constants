namespace HelseID.Constants.Claims
{
    public static class ClientClaims
    {
        private const string Prefix = HelseIdPrefix.Prefix + "client/";

        public const string ParentOrganizationNumber = Prefix + "ec/orgnr_parent";

        public const string ChildOrganizationNumber = Prefix + "ec/orgnr_child";

        public const string CertificateExpiryDate = Prefix + "ec/exp";

        public const string Kj = Prefix + "kj/orgnr";

        public const string Amr = Prefix + "amr";

        public static string[] All { get; } =
            {  ParentOrganizationNumber, ChildOrganizationNumber, CertificateExpiryDate, Kj, Amr };
    }
}
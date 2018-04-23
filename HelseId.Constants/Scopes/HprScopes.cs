
using HelseID.Constants.Scopes;

namespace HelseId.Constants.Scopes
{
    public static class HprScopes
    {
        private const string Prefix = HelseIdPrefix.Prefix + "hpr";

        public const string HprNumber = Prefix + "/hpr_number";

        public static string[] All { get; } = { HprNumber };
    }
}
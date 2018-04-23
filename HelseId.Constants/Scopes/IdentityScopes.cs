using HelseID.Constants.Scopes;

namespace HelseId.Constants.Scopes
{
    public static class IdentityScopes
    {
        private const string Prefix = HelseIdPrefix.Prefix + "identity/";

        public const string AssuranceLevel = Prefix + "assurance_level";
        public const string Pid = Prefix + "pid";
        public const string PidPseudonym = Pid + "_pseudonym";
        public const string SecurityLevel = Prefix + "security_level";

        public static string[] All { get; } = { AssuranceLevel, Pid, PidPseudonym, SecurityLevel };
    }
}
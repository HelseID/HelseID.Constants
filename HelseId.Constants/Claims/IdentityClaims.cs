using HelseID.Constants.Claims;

namespace HelseId.Constants.Claims
{
    public static class IdentityClaims
    {
        private const string Prefix = HelseIdPrefix.Prefix + "identity/";

        public const string AssuranceLevel = Prefix + "assurance_level";
        public const string Pid = Prefix + "pid";
        public const string PidPseudonym = Prefix + "pid_pseudonym";
        public const string SecurityLevel = Prefix + "security_level";

        public static string[] All { get; } = { AssuranceLevel, Pid, PidPseudonym, SecurityLevel };
    }
}
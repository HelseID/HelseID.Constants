using System.Linq;
using HelseID.Constants.Scopes;

namespace HelseId.Constants.Scopes
{
    public static class AllScopes
    {
        public static string[] All { get; } = StandardScopes.All
            .Concat(IdentityScopes.All)
            .Concat(HprScopes.All)
            .Concat(ClientScopes.All)
            .ToArray();
    }
}
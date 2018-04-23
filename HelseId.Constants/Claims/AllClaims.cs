using System.Linq;
using HelseID.Constants.Claims;

namespace HelseId.Constants.Claims
{
    public static class AllClaims
    {
        public static string[] All { get; } = StandardClaims.All
            .Concat(IdentityClaims.All)
            .Concat(HprClaims.All)
            .Concat(ClientClaims.All)
            .ToArray();
    }
}
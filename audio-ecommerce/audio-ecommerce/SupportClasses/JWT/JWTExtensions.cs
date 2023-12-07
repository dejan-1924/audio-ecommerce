using System.Security.Claims;

namespace IIS_Projekat.SupportClasses.Extensions
{
    public static class JWTExtensions
    {
        public static string GetId(this ClaimsPrincipal claims)
        {
            return claims.FindFirstValue(ClaimTypes.Name);
        }
    }
}
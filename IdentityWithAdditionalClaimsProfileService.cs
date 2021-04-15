using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using WebApplication2.Models;
using Microsoft.AspNetCore.Identity;
using IdentityServer4;
using WebApplication2.Models;

namespace WebApplication2
{
    public class IdentityWithAdditionalClaimsProfileService : IProfileService
    {
        public readonly IUserClaimsPrincipalFactory<WebApplication2User> _claimsFactory;
        private readonly UserManager<WebApplication2User> _userManager;


        public IdentityWithAdditionalClaimsProfileService(UserManager<WebApplication2User> userManager, 
                IUserClaimsPrincipalFactory<WebApplication2User> claimsFactory)
        {
            _userManager = userManager;
            _claimsFactory = claimsFactory;
        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            var principal = await _claimsFactory.CreateAsync(user);

            var claims = principal.Claims.ToList();
            claims = claims.Where(claim => context.RequestedClaimTypes.Contains(claim.Type)).ToList();
            
            // Add more custom claim types pertaining to default user of the angular client and apis
            // claims.Add(new Claim(JwtClaimTypes.Role, ""))
            
            claims.Add(new Claim(JwtClaimTypes.Role, "recipeantwebapi.user"));
            claims.Add(new Claim(JwtClaimTypes.Role, "recipeantwebapi"));
            claims.Add(new Claim(JwtClaimTypes.Scope, "recipeantwebapi"));
            
            claims.Add(new Claim(JwtClaimTypes.GivenName, user.UserName));

            if (user.IsAdmin)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "admin"));
            }
            else
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "user"));
            }

            if (user.RecipeAntRole == "recipeantwebapi.admin")
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "recipeantwebapi.admin"));
            }
            claims.Add(new Claim(IdentityServerConstants.StandardScopes.Email, user.Email));
            claims.Add(new Claim("name", user.Email));
            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var sub = context.Subject.GetSubjectId();
            var user = await _userManager.FindByIdAsync(sub);
            context.IsActive = user != null;
        }
    }
}

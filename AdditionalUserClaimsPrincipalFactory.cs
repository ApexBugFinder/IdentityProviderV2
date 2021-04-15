using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using WebApplication2.Models;

namespace WebApplication2
{
    public class AdditionalUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<WebApplication2User, IdentityRole>
    {

        public AdditionalUserClaimsPrincipalFactory(
            UserManager<WebApplication2User> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager, optionsAccessor) 
        { 
        }

        public async override Task<ClaimsPrincipal> CreateAsync(WebApplication2User user)
        {
            var principal = await base.CreateAsync(user);
            var identity = (ClaimsIdentity)principal.Identity;

            var claims = new List<Claim>
            {
                new Claim(JwtClaimTypes.Role, "recipeantwebapi"),
                new Claim(JwtClaimTypes.Role, "recipeantwebapi.user")
            };

            if (user.RecipeAntRole == "recipeantwebapi.admin")
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "recipeantwebapi.admin"));
            }

            if (user.IsAdmin)
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "admin"));
            }
            else
            {
                claims.Add(new Claim(JwtClaimTypes.Role, "user"));
            }
            identity.AddClaims(claims);
            return principal;
        }
            
    }
}

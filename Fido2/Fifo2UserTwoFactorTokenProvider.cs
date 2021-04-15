using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public class Fifo2UserTwoFactorTokenProvider : IUserTwoFactorTokenProvider<WebApplication2User>
    {
        public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<WebApplication2User> manager, WebApplication2User user)
        {
            return Task.FromResult(true);
        }

        public Task<string> GenerateAsync(string purpose, UserManager<WebApplication2User> manager, WebApplication2User user)
        {
            return Task.FromResult("fido2"); 
        }
        public Task<bool> ValidateAsync(string purpose, string token, UserManager<WebApplication2User> manager, WebApplication2User user)
        {
            return Task.FromResult(true);
        }
    }
   
}

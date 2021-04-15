using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    // Add profile data for application users by adding properties to the WebApplication2User class
    public class WebApplication2User : IdentityUser
    {
        public bool IsAdmin { get; set; }
        /// <summary>
        /// add Roles
        /// public string RecipeAntRole { get; set; }
        /// 
        /// </summary>
        public string DataEventRecordsRole { get; set; }
        public string SecuredFilesRole { get; set; } 
        public string RecipeAntRole { get; set; }
    }
}

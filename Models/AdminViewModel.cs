using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class AdminViewModel
    {
        [Required]
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public string RecipeAntRole { get; set; }

        public string SecuredFilesRole { get; set; }        
    }
}

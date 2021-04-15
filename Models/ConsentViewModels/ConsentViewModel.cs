using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using WebApplication2.Models.ConsentViewModels;

namespace WebApplication2.Models
{
    public class ConsentViewModel : ConsentInputModel
    {     
       public string ClientName { get; set; }
        public string ClientUrl { get; set; }
        public string ClientLogoUrl { get; set; }
        public bool AllowRememberConsent { get; set; }

        public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }
        public IEnumerable<ScopeViewModel> ApiScopes { get; set; }


    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.AccountViewModels
{
    public class MfaModel
    {
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}

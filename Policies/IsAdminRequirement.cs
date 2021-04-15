using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Policies
{
    public class IsAdminRequirement : IAuthorizationRequirement 
    {
    }
}

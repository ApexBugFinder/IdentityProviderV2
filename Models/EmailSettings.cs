using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EmailSettings
    {
        public string SendGridApiKey { get; set; }
        public string SenderEmailAddress { get; set; }
    }
}

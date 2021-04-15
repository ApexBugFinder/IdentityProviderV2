﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Filters
{
    public class SecurityHeadersAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result;
            if (result is ViewResult)
            {
                var featurePolicy = "accelerometer 'none'; camera 'none'; geolocation 'none'; " +
                    "gyroscope 'none'; magnetometer 'none'; microphone 'none'; payment 'none'; usb 'none'";

                if (!context.HttpContext.Response.Headers.ContainsKey("feature-policy"))
                    context.HttpContext.Response.Headers.Add("feature-policy", featurePolicy);


                if (!context.HttpContext.Response.Headers.ContainsKey("X-Content-Type-Options"))
                    context.HttpContext.Response.Headers.Add("X-Content-Type-Options", "nosniff");


                if (!context.HttpContext.Response.Headers.ContainsKey("X-Frame-Options"))
                    context.HttpContext.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");

                var csp = "script-src 'self' 'unsafe-inline';style-src 'self' 'unsafe-inline';img-src 'self' data:;font-src 'self';" +
                    "form-action 'self';frame-ancestors 'self'; block-all-mixed-content";

                // once for all standards compliant browsers
                if (!context.HttpContext.Response.Headers.ContainsKey("Content-Security-Policy"))
                    context.HttpContext.Response.Headers.Add("Content-Security-Policy", csp);
            }
            base.OnResultExecuting(context);
        }
    }
    
}

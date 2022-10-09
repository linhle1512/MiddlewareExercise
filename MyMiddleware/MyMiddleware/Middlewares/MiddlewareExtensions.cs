using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMiddleware.Middlewares
{
    public static class MiddlewareExtensions
    {       public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogginMiddleware>();
        }
    }
}

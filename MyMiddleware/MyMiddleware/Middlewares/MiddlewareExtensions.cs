using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMiddleware.Middlewares
{
    public class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseLogginMiddleware<LogginMiddleware>();
        }
    }
}

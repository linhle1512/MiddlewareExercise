using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MyMiddleware.Middlewares
{
    public class LogginMiddleware
    {
        private readonly RequestDelegate _next;

        public LogginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            string requestInfo = "Scheme: " + request.Scheme +
                "\t Host: " + request.Host +
                "\t Path: " + request.Path +
                "\t QueryString: " + request.QueryString +
                "\t RequestBody: " + request.Body;

            Debug.Write(requestInfo);
            File.WriteAllText("C:\\textInformation.txt", requestInfo);
            await _next(context);
        }

    }
}

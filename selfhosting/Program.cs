using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace SelfHosting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:8080")
                //.UseStartup<Startup>()
                .Configure(c =>
                    c.Run(
                        async
                            context => // This is just to pinpoint the error, the controller seems to be swallowing the error
                        {
                            Console.WriteLine("writing response");
                            await context.Response.WriteAsync("Hello world");
                        }
                    )
                )
                .Build();

            host.Run();
        }
    }
}
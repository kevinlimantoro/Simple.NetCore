using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace core_multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var config = new ConfigurationBuilder().Build();

            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .UseConfiguration(config)
            .Build();

            host.Run();
        }
    }
}

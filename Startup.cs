using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace core_multithread{
    public class Startup{
        public Startup(IHostingEnvironment env)
        {

        }

        public void Configure(IApplicationBuilder app,
                        IHostingEnvironment environment, ILoggerFactory loggerFactory){
                            app.Run(async(context) => {
                                await context.Response.WriteAsync("Hello, World!");
                            });
                        }
    }
}

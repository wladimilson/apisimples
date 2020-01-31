using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSimples.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ApiSimples
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddControllers();
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles(); 
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<StreamingHub>("/streaminghub"); 
            });
        }
    }
}

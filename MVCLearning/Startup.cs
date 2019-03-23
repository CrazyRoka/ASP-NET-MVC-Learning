using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MVCLearning.Models;
using MVCLearning.Services;

namespace MVCLearning
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<EventsAndMenusContext>();
            services.AddScoped<ISampleService, SampleService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes => routes.MapRoute(
                name: "default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Home", action = "Index" })
                .MapRoute(
                    name: "multipleparameters",
                    template: "{controller}/{action}/{x:int}/{y:int}",
                    defaults: new { controller = "Home", action = "Add" },
                    constraints: new { x = @"\d{1,3}", y = @"\d{1,3}" }
                ));

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

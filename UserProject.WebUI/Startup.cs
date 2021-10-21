using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserProject.Business.Abstract;
using UserProject.Business.Concrete;
using UserProject.DataAccess.Abstract;
using UserProject.DataAccess.Concrete.EfCore;
namespace UserProject.WebUI
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)//Adding services to our project
        {
            services.AddScoped<IWorkRepository,EfCoreWorkRepository>(); // Biz IWorkRepository çağırdığımızda
            services.AddScoped<IWorkService,WorkManager>();
            services.AddControllersWithViews();//Core containes MVC     // EfCoreWorkRepository'i çalıştırsın.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });*/

            app.UseEndpoints(endpoints=>{
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}

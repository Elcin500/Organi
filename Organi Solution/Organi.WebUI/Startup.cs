using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Organi.WebUI.Models.DataContext;

namespace Organi.WebUI
{
    public class Startup
    {
        readonly IConfiguration conf;
        public Startup(IConfiguration conf)
        {
            this.conf = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddRouting(opt=> {
                opt.LowercaseUrls = true;
                opt.LowercaseQueryStrings = true;
            });
            services.AddDbContext<OrganiDbContext>(cfg =>
           {
              // cfg.UseInMemoryDatabase(databaseName: "Organi");

              cfg.UseSqlServer(conf.GetConnectionString("cString"));
           }) ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Seed();

            app.UseStaticFiles();
            app.UseRouting();
            //  app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "areas",
                    areaName: "Admin",
                    pattern: "Admin/{controller=dashboard}/{action=index}/{id?}"
                    );

                //endpoints.MapControllerRoute(
                //  name: "areas",
                //  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                //   );


                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controller=home}/{action=index}/{id:int:min(1)?}"
                    // Bu asagidakilar id-nin yanindakinin uzun versiyasidi
                    //constraints:new { 
                    //     id=new IRouteConstraint[] 
                    //     { 
                    //         new IntRouteConstraint(),
                    //         new MinRouteConstraint(1)
                    //     }

                    //}
                    );
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using NFLTeamApp.Models;

namespace NFLTeamApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
            //services.AddControllersWithViews();
            //services.AddDbContext<TeamContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("TeamContext")));
        }
        // Use this method to configure the HTTP request pipeline. 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting(); // mark where routing decisions are made

            // configure middleware that runs after routing decisions have been made

            app.UseEndpoints(endpoints => // map the endpoints 
            {
                endpoints.MapControllerRoute(
                    name: "custom",
                    pattern: "{controller}/{action}/conf/{activeConf}/div{activeDiv}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
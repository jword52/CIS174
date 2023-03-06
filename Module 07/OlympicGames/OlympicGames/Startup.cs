using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using OlympicGames.Models;
using Newtonsoft.Json;


namespace OlympicGames
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options =>
                options.LowercaseUrls = true);


            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews().AddNewtonsoftJson();

            services.AddDbContext<CountryContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CountryContext")));


        }
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "",
                    pattern: "{controller=Home}/{action=Index}/game/{activeGame}/sport/{activeSport}/location/{activeLocation}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
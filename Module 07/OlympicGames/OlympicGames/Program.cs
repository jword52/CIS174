using Microsoft.EntityFrameworkCore;
using OlympicGames.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using OlympicGames;

namespace OlympicGames

{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

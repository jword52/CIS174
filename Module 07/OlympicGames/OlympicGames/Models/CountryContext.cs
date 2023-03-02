using Microsoft.EntityFrameworkCore;
using OlympicGames.Models;

namespace OlympicGames.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) 
            : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "wo", GameName = "Winter Olympics" },
                new Game { GameID = "so", GameName = "Summer Olympics" },
                new Game { GameID = "po", GameName = "Paralympics" },
                new Game { GameID = "yo", GameName = "Youth Olympic Games" }
            );

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "cur", SportName = "Curling" },
                new Sport { SportID = "bob", SportName = "Bobsleigh" },
                new Sport { SportID = "div", SportName = "Diving" },
                new Sport { SportID = "cyc", SportName = "Road Cycling" },
                new Sport { SportID = "arc", SportName = "Archery" },
                new Sport { SportID = "can", SportName = "Canoe Sprint" },
                new Sport { SportID = "bre", SportName = "Breakdancing" },
                new Sport { SportID = "ska", SportName = "Skateboarding" }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location { LocationID = "in", LocationName = "Indoors" },
                new Location { LocationID = "out", LocationName = "Outdoors" }
            );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "CA", CountryName = "Canada", GameID = "wo", SportID = "cur", LocationID = "in", FlagImg = "CA.png" },
                new { CountryID = "SE", CountryName = "Sweden", GameID = "wo", SportID = "cur", LocationID = "in", FlagImg = "SE.png" },
                new { CountryID = "GB", CountryName = "Great Britain", GameID = "wo", SportID = "cur", LocationID = "in", FlagImg = "GB.png" },
                new { CountryID = "JM", CountryName = "Jamaica", GameID = "wo", SportID = "bob", LocationID = "out", FlagImg = "JM.png" },
                new { CountryID = "IT", CountryName = "Italy", GameID = "wo", SportID = "bob", LocationID = "out", FlagImg = "IT.png" },
                new { CountryID = "JP", CountryName = "Japan", GameID = "wo", SportID = "bob", LocationID = "out", FlagImg = "JP.png" },
                new { CountryID = "DE", CountryName = "Germany", GameID = "so", SportID = "div", LocationID = "in", FlagImg = "DE.png" },
                new { CountryID = "CN", CountryName = "China", GameID = "so", SportID = "div", LocationID = "in", FlagImg = "CN.png" },
                new { CountryID = "MX", CountryName = "Mexico", GameID = "so", SportID = "div", LocationID = "in", FlagImg = "MX.png" },
                new { CountryID = "BR", CountryName = "Brazil", GameID = "so", SportID = "cyc", LocationID = "out", FlagImg = "BR.png" },
                new { CountryID = "NL", CountryName = "Netherlands", GameID = "so", SportID = "cyc", LocationID = "out", FlagImg = "NL.png" },
                new { CountryID = "US", CountryName = "USA", GameID = "so", SportID = "cyc", LocationID = "out", FlagImg = "US.png" },
                new { CountryID = "TH", CountryName = "Thailand", GameID = "po", SportID = "arc", LocationID = "in", FlagImg = "TH.png" },
                new { CountryID = "UY", CountryName = "Uruguay", GameID = "po", SportID = "arc", LocationID = "in", FlagImg = "UY.png" },
                new { CountryID = "UA", CountryName = "Ukraine", GameID = "po", SportID = "arc", LocationID = "in", FlagImg = "UA.png" },
                new { CountryID = "AT", CountryName = "Austria", GameID = "po", SportID = "can", LocationID = "out", FlagImg = "AT.png" },
                new { CountryID = "PK", CountryName = "Pakistan", GameID = "po", SportID = "can", LocationID = "out", FlagImg = "PK.png" },
                new { CountryID = "ZW", CountryName = "Zimbabwe", GameID = "po", SportID = "can", LocationID = "out", FlagImg = "ZW.png" },
                new { CountryID = "FR", CountryName = "France", GameID = "yo", SportID = "bre", LocationID = "in", FlagImg = "FR.png" },
                new { CountryID = "CY", CountryName = "Cyprus", GameID = "yo", SportID = "bre", LocationID = "in", FlagImg = "CY.png" },
                new { CountryID = "RU", CountryName = "Russia", GameID = "yo", SportID = "bre", LocationID = "in", FlagImg = "RU.png" },
                new { CountryID = "FI", CountryName = "Finland", GameID = "yo", SportID = "ska", LocationID = "out", FlagImg = "FI.png" },
                new { CountryID = "SK", CountryName = "Slovakia", GameID = "yo", SportID = "ska", LocationID = "out", FlagImg = "SK.png" },
                new { CountryID = "PT", CountryName = "Portugal", GameID = "yo", SportID = "ska", LocationID = "out", FlagImg = "PT.png" }
            );
        }
    }
}
using Microsoft.EntityFrameworkCore;


namespace NFLTeamApp.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set;}
        public DbSet<Conference> Conferences { get; set;}
        public DbSet<Division> Divisions { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Conference>().HasData(
                new Conference { ConferenceID = "afc", Name = "AFC" },
                new Conference { ConferenceID = "nfc", Name = "NFC" }
                );
            modelBuilder.Entity<Division>().HasData(
                new Division { DivisionID = "north", Name = "NORTH" },
                new Division { DivisionID = "south", Name = "SOUTH" },
                new Division { DivisionID = "west", Name = "WEST" },
                new Division { DivisionID = "east", Name = "EAST" }
                );
            modelBuilder.Entity<Team>().HasData(
                new {TeamID = "ari", Name = "Arizona Cardinals",
                     ConferenceID = "nfc", DivisionID = "west",
                      LogoImage = "ARI.png"},
                new {TeamID = "sf", Name = "San Francisco 49ers",
                     ConferenceID = "nfc", DivisionID = "west",
                      LogoImage = "SF.png"},
                new {TeamID = "sea", Name = "Seattle Seahawks",
                     ConferenceID = "nfc", DivisionID = "west",
                      LogoImage = "SEA.png"},
                new {TeamID = "lar", Name = "Los Angeles Rams",
                     ConferenceID = "nfc", DivisionID = "west",
                      LogoImage = "LAR.png"},
                new {TeamID = "tb", Name = "Tampa Bay Buccaneers",
                     ConferenceID = "nfc", DivisionID = "south",
                      LogoImage = "TB.png"},
                new {TeamID = "cp", Name = "Carolina Panthers",
                     ConferenceID = "nfc", DivisionID = "south",
                      LogoImage = "CP.png"},
                new {TeamID = "no", Name = "New Orleans Saints",
                     ConferenceID = "nfc", DivisionID = "south",
                      LogoImage = "NO.png"},
                new {TeamID = "atl", Name = "Atlanta Falcons",
                     ConferenceID = "nfc", DivisionID = "south",
                      LogoImage = "ATL.png"},
                new {TeamID = "min", Name = "Minnesota Vikings",
                     ConferenceID = "nfc", DivisionID = "north",
                      LogoImage = "MIN.png"},
                new {TeamID = "det", Name = "Detroit Lions",
                     ConferenceID = "nfc", DivisionID = "north",
                      LogoImage = "DET.png"},
                new {TeamID = "gb", Name = "Green Bay Packers",
                     ConferenceID = "nfc", DivisionID = "north",
                      LogoImage = "GB.png"},
                new {TeamID = "cb", Name = "Chicago Bears",
                     ConferenceID = "nfc", DivisionID = "north",
                      LogoImage = "CB.png"},
                new {TeamID = "phil", Name = "Philadelphia Eagles",
                     ConferenceID = "nfc", DivisionID = "east",
                      LogoImage = "PHIL.png"},
                 new {TeamID = "dal", Name = "Dallas Cowboys",
                     ConferenceID = "nfc", DivisionID = "east",
                      LogoImage = "DAL.png"},
                  new {TeamID = "nyg", Name = "New York Giants",
                     ConferenceID = "nfc", DivisionID = "east",
                      LogoImage = "NYG.png"},
                   new {TeamID = "wash", Name = "Washington Commanders",
                     ConferenceID = "nfc", DivisionID = "east",
                      LogoImage = "WASH.png"},
                    new {TeamID = "buf", Name = "Buffalo Bills",
                     ConferenceID = "afc", DivisionID = "east",
                      LogoImage = "BUF.png"},
                    new {TeamID = "Miami", Name = "Miami Dolphins",
                     ConferenceID = "afc", DivisionID = "east",
                      LogoImage = "MIAMI.png"},
                    new {TeamID = "pats", Name = "New England Patriots",
                     ConferenceID = "afc", DivisionID = "east",
                      LogoImage = "PATS.png"},
                    new {TeamID = "nyj", Name = "New York Jets",
                     ConferenceID = "afc", DivisionID = "east",
                      LogoImage = "NYJ.png"},
                    new {TeamID = "cinn", Name = "Cincinnati Bengals",
                     ConferenceID = "afc", DivisionID = "north",
                      LogoImage = "CINN.png"},
                    new {TeamID = "bal", Name = "Baltimore Ravens",
                     ConferenceID = "afc", DivisionID = "north",
                      LogoImage = "BAL.png"},
                    new {TeamID = "pitt", Name = "Pittsburgh Steelers",
                     ConferenceID = "afc", DivisionID = "north",
                      LogoImage = "PITT.png"},
                    new {TeamID = "cle", Name = "Cleveland Browns",
                     ConferenceID = "afc", DivisionID = "north",
                      LogoImage = "cle.png"},
                    new {TeamID = "jack", Name = "Jacksonville Jaguars",
                     ConferenceID = "afc", DivisionID = "south",
                      LogoImage = "JACK.png"},
                    new {TeamID = "tenn", Name = "Tennessee Titans",
                     ConferenceID = "afc", DivisionID = "south",
                      LogoImage = "TENN.png"},
                    new {TeamID = "indy", Name = "Indianapolis Colts",
                     ConferenceID = "afc", DivisionID = "south",
                      LogoImage = "INDY.png"},
                    new {TeamID = "hou", Name = "Houston Texans",
                     ConferenceID = "afc", DivisionID = "south",
                      LogoImage = "HOU.png"},
                    new {TeamID = "kc", Name = "Kansas City Chiefs",
                     ConferenceID = "afc", DivisionID = "west",
                      LogoImage = "KC.png"},
                    new {TeamID = "lac", Name = "Los Angeles Chargers",
                     ConferenceID = "afc", DivisionID = "west",
                      LogoImage = "LAC.png"},
                    new {TeamID = "lvr", Name = "Los Vegas Raiders",
                     ConferenceID = "afc", DivisionID = "west",
                      LogoImage = "LAV.png"},
                    new {TeamID = "dev", Name = "Denver Broncos",
                     ConferenceID = "afc", DivisionID = "west",
                      LogoImage = "DEV.png"}
                );
        }
    }
}

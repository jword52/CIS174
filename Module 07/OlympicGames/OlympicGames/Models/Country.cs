using OlympicGames.Models;

namespace OlympicGames.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public Game Game { get; set; }
        public Sport Sport { get; set; }
        public Location Location { get; set; }
        public string FlagImg { get; set; }
    }
}
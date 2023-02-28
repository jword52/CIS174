namespace OlympicGames.Models
{
    public class CountryViewModel
    {
        public Country? Country { get; set; }
        public string ActiveSport { get; set; } = "all";
        public string ActiveGame { get; set; } = "all";
        public string ActiveLocation { get; set; } = "all";
    }
}

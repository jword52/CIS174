


namespace OlympicGames.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveSport { get; set; }
        public string ActiveGame { get; set; }
        public string ActiveLocation { get; set; }

        private List<Sport> sports;
        public List<Sport> Sports
        {
            get => sports;
            set
            {
                sports = value;
                sports.Insert(0,
                    new Sport
                    {
                        SportID = "all",
                        SportName = "All"
                    });
            }

        }
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game
                    {
                        GameID = "all",
                        GameName = "All"
                    });
            }
        }
        private List<Location> locations;
        public List<Location> Locations
        {
            get => locations;
            set
            {
                locations = value;
                locations.Insert(0,
                    new Location
                    {
                        LocationID = "all",
                        LocationName = "All"
                    });
            }
        }
        public string CheckActiveSport(string s) =>
            s.ToLower() == ActiveSport.ToLower() ? "active" : "";

        public string CheckActiveGame(string g) =>
            g.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveLocation(string l) =>
            l.ToLower() == ActiveLocation.ToLower() ? "active" : "";
    }
}

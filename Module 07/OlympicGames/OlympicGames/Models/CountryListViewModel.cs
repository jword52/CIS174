


namespace OlympicGames.Models
{
    public class CountryListViewModel : CountryViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveSport { get; set; } = "all";
        public string ActiveGame { get; set; } = "all";
        public string ActiveLocation { get; set; } = "all";


        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = new List<Game>
                {

                    new Game
                    {
                        GameID = "all",
                        GameName = "All"
                    }};
                games.AddRange(value);
            }
        }

        private List<Sport> sports;
        public List<Sport> Sports
        {
            get => sports;
            set
            {
                sports = new List<Sport>
                {
                    new Sport
                    {
                        SportID = "all",
                        SportName = "All"
                    }};
                sports.AddRange(value);
            }

        }
        
        private List<Location> locations;
        public List<Location> Locations
        {
            get => locations;
            set
            {
                locations = new List<Location>
                {                    new Location
                    {
                        LocationID = "all",
                        LocationName = "All"
                    }};
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

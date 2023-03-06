using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OlympicGames.Models
{
    public class OlympicSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "teamcount";
        private const string GameKey = "game";
        private const string SportKey = "sport";
        private const string LocationKey = "location";

        private ISession session { get; set; }

        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();

        public int? GetMyCountryCount() => session.GetInt32(CountKey);

        public void SetActiveGame(string activeGame) =>
            session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey);

        public void SetActiveSport(string activeSport) =>
            session.SetString(SportKey, activeSport);

        public string GetActiveSport() => session.GetString(SportKey);

        public void SetActiveLocation(string activLocation) =>
            session.SetString(LocationKey, activLocation);
        public string GetActiveLocation() => session.GetString(LocationKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}

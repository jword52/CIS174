﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlympicGames.Models;
using System.Diagnostics;

namespace OlympicGames.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;
        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index(string activeGame = "all", string activeSport = "all", string activeLocation = "all")

        {

            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveGame(activeGame);
            session.SetActiveSport(activeSport);
            session.SetActiveLocation(activeLocation);

            // if no count value in session, use data in cookie to restore fave countries in session 
            int? count = session.GetMyCountryCount();
            if (count == null)
            {
                var cookies = new OlympicCookies(Request.Cookies);
                string[] ids = cookies.GetMyCountryIds();

                List<Country> mycountries = new List<Country>();
                if (ids.Length > 0)
                    mycountries = context.Countries.Include(g => g.Game)
                        .Include(s => s.Sport)
                        .Include(l => l.Location)
                        .Where(t => ids.Contains(t.CountryID)).ToList();
                session.SetMyCountries(mycountries);
            }


            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveSport = activeSport,
                ActiveLocation = activeLocation,
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList(),
                Locations = context.Locations.ToList(),
            };
     

            IQueryable<Country> query = context.Countries;

            if (activeGame != "all")
                query = query.Where(g => g.Game.GameID.ToLower() == activeGame.ToLower());

            if (activeSport != "all")
                query = query.Where(s => s.Sport.SportID.ToLower() == activeSport.ToLower());

            if (activeLocation != "all")
                query = query.Where(l => l.Location.LocationID.ToLower() == activeLocation.ToLower());

            model.Countries = query.ToList();
            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                .Include(g => g.Game)
                .Include(s => s.Sport)
                .Include(l => l.Location)
                .FirstOrDefault(c => c.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                ActiveLocation = session.GetActiveLocation(),
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel data)
        {

        data.Country = context.Countries
            .Include(g => g.Game)
            .Include(s => s.Sport)
            .Include(l => l.Location)
            .Where(t => t.CountryID == data.Country.CountryID)
            .FirstOrDefault();

        var session = new OlympicSession(HttpContext.Session);
        var countries = session.GetMyCountries();
        countries.Add(data.Country);
        session.SetMyCountries(countries);

            var cookies = new OlympicCookies(Response.Cookies);
            cookies.SetMyCountryIds(countries);

            TempData["message"] = $"{data.Country.CountryName} added to your faorites";

        return RedirectToAction("Index",
            new
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                ActiveLocation = session.GetActiveLocation(),
            });


        }
      
        

    }
}

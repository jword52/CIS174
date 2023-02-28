using Microsoft.AspNetCore.Mvc;
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
        public ViewResult Index(string activeGame = "all", string activeSport = "all", string activeLocation = "all")

        {
            var model = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveSport = activeSport,
                ActiveLocation = activeLocation,
                Games = context.Games.ToList(),
                Sports = context.Sports.ToList(),
                Locations = context.Locations.ToList(),
            };
            //ViewBag.activeGame = activeGame;
            //ViewBag.activeSport = activeSport;
            //ViewBag.activeLocation = activeLocation;

            //List<Game> games = context.Games.ToList();
            //List<Sport> sports= context.Sports.ToList();
            //List<Location> locations = context.Locations.ToList();

            IQueryable<Country> query = context.Countries;

            if (activeGame != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());

            if (activeSport != "all")
                query = query.Where(t => t.Sport.SportID.ToLower() == activeSport.ToLower());
            if (activeLocation != "all")
                query = query.Where(t => t.Location.LocationID.ToLower() == activeLocation.ToLower());

            model.Countries = query.ToList();
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {
            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveSport"] = model.ActiveSport;
            TempData["ActiveLocation"] = model.ActiveLocation;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                .Include(g => g.Game)
                .Include (s => s.Sport)
                .Include(t => t.Location)
                .FirstOrDefault(c => c.CountryID == id),
                ActiveGame = TempData?["ActiveGame"]?.ToString() ?? "all",
                ActiveSport = TempData?["ActiveSport"]?.ToString() ?? "all",
                ActiveLocation = TempData?["ActiveLocation"]?.ToString() ?? "all"
            };
            return View(model);
        }

    }
}

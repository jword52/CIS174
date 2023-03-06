using Microsoft.AspNetCore.Mvc;
using OlympicGames.Models;

namespace OlympicGames.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryListViewModel
            {
                ActiveGame = session.GetActiveGame(),
                ActiveSport = session.GetActiveSport(),
                ActiveLocation= session.GetActiveLocation(),
                Countries = session.GetMyCountries()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            var cookies = new OlympicCookies(Response.Cookies);

            session.RemoveMyCountries();
            cookies.RemoveMyCountryIds();

            TempData["message"] = "Favorite teams cleared";

            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveConf = session.GetActiveGame(),
                    ActiveDiv = session.GetActiveSport(),
                    ActiveLocation = session.GetActiveLocation(),
                });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NFLTeamApp.Models;

namespace NFLTeamApp.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context;
        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeConf = "all", string activeDiv = "all")
        {
            var model = new TeamListViewModel
            {
                ActiveConf = activeConf,
                ActiveDiv = activeDiv,
                Conferences = context.Conferences.ToList(),
                Divisions = context.Divisions.ToList()
            };
            //store selected conference and division IDs in the view bag
            ViewBag.ActiveConf = activeConf;
            ViewBag.ActiveDiv = activeDiv;

            //get list of conferences and divisions from database
            List<Conference> conferences= context.Conferences.ToList();
            List<Division> divisions= context.Divisions.ToList();

            //insert default "All" value at front of each list
            conferences.Insert(0, new Conference { ConferenceID = "all", 
                                                   Name = "All" });
            divisions.Insert(0, new Division { DivisionID = "all", 
                                               Name = "All" });

            //store lists in view bag
            ViewBag.Conferences = conferences;
            ViewBag.Divisions = divisions;

            //get teams - filter by conference and division
            IQueryable<Team> query = context.Teams;
            if (activeConf != "all")
            
                query = query.Where(
                    t => t.Conference.ConferenceID.ToLower() == activeConf.ToLower());
            if (activeDiv != "all")
                query = query.Where(
                    t => t.Division.DivisionID.ToLower() == activeDiv.ToLower());
            //pass teams to view as model
            model.Teams = query.ToList();
                return View(model);
            
        }
        //public RedirectToActionResult Index() => RedirectToAction("List");
        ////public RedirectToActionResult Index() => RedirectToAction("List", "Team");

        //[HttpPost]
        //public RedirectToActionResult Details(TeamListViewModel model)
        //{
        //    Utility.LogTeamClick(model.Teams.TeamID);
        //    TempData["ActiveConf"] = model.ActiveConf;
        //    TempData["ActiveDiv"] = model.ActiveDiv;
        //    return RedirectToAction("Details", new { ID = model.Teams.TeamID });

        //}
        //[HttpGet]
        //public ViewResult Details (string id)
        //{
        //    var model = new TeamListViewModel
        //    {
        //        Team = context.Teams
        //        .Include(t => t.Conference)
        //        .Include(t => t.Division)
        //        .FirstOrDefault(t => t.TeamID == id),
        //        ActiveConf = TempData.Peek("ActiveConf").ToString(),
        //        ActiveDiv = TempData.Peek("ActiveDiv").ToString()

        //    };
        //    return View(model);
        //}
    }
}

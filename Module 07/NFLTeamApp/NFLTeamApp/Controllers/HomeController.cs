﻿using Microsoft.AspNetCore.Mvc;
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
            ////store conference and division IDs in viewbag
            //ViewBag.ActiveConf = activeConf;
            //ViewBag.ActiveDiv = activeDiv;

            //ViewBag.Conferences = context.Conferences.ToList();
            //ViewBag.Divisions = context.Divisions.ToList();

            //get teams - filter by conference and division
            IQueryable<Team> query = context.Teams;

            if(activeConf != "all")
                query = query.Where(t 
                    => t.Conference.ConferenceID.ToLower() == 
                    activeConf.ToLower());

            if(activeDiv != "all")
                query = query.Where(t => 
                t.Division.DivisionID.ToLower() ==
                activeDiv.ToLower());

            //executes query
            model.Teams = query.ToList();
            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Details(TeamViewModel model)
        {
            //Utility.LogTeamClick(model.Team.TeamID);
            TempData["ActiveConf"] = model.ActiveConf;
            TempData["ActiveDiv"] = model.ActiveDiv;
            return RedirectToAction("Details",
                        new { ID = model.Team.TeamID });
        }
        [HttpGet]
        public ViewResult Details(string id)
        {
            var model = new TeamViewModel
            {
                Team = context.Teams
                .Include(t => t.Conference)
                .Include(t => t.Division)
                .FirstOrDefault(t => t.TeamID == id),
                ActiveConf = TempData?["ActiveConf"]?.ToString() ?? "all",
                ActiveDiv = TempData?["ActiveDiv"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
    }


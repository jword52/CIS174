using FirstResponsiveWebAppOrd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppOrd.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            ViewBag.AgeAtEndOfYear = 0;
            ViewBag.Name = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(FirstResponseModel model)
        {
            if (ModelState.IsValid)  // Check valid state
            {
                ViewBag.Age = model.AgeThisYear();  // Calls Function of Current Age
                ViewBag.AgeAtEndOfYear = model.AgeByEndOfYear(); 
                ViewBag.Name = model.Name;  // Assign name
            }
            else // Assign defaults
            {
                ViewBag.Age = 0;
                ViewBag.AgeAtEndOfYear = 0;
                ViewBag.Name = "";
            }
            return View(model);
        }
    }
}

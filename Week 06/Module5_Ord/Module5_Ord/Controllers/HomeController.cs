using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module5_Ord.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Module5_Ord.Controllers
{
    public class HomeController : Controller
    {
       private ContactContext context { get; set; }
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
       
        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
        
        public IActionResult Admin()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult ContactUs()
        {
            return View();
        }

        

    }
}
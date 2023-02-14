using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Module5_Ord.Models;
using System.Diagnostics;
using System.Linq;

namespace Module5_Ord.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            var contacts = context.Contacts.OrderBy(c => c.ContactName).ToList();
            return View(contacts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
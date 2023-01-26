using Ch02Multi_PageWebAppOrd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Ch02Multi_PageWebAppOrd.Controllers
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
    }
}
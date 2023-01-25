using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module02ContactsOrd.Models;
using System.Linq;

namespace Module02ContactsOrd.Controllers
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
            var contacts = context.Contacts.Include(m => m.ContactFriend).OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
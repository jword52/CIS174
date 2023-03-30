using Microsoft.AspNetCore.Mvc;
using System;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class RegisterController : Controller
    {
        private TicketContext context;
        public RegisterController(TicketContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (TempData["okEmail"] == null)
            {
                string msg = Check.EmailExists(context, user.EmailAddress);
                if (!String.IsNullOrEmpty(msg))
                {
                    ModelState.AddModelError(nameof(user.EmailAddress), msg);
                }
            }

            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Welcome");
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Welcome(User user)
        {
            return View();
        }
    }
}
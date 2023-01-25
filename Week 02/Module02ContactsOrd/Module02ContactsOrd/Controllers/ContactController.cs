using Microsoft.AspNetCore.Mvc;
using Module02ContactsOrd.Models;
using System.Linq;

namespace Module02ContactsOrd.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Friends = context.Friends.OrderBy(cf => cf.CName).ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Friends = context.Friends.OrderBy(cf => cf.CName).ToList();
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if(ModelState.IsValid)            {
                if(contact.ContactId== 0)                
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");                
                
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Friends = context.Friends.OrderBy(cf => cf.CName).ToList();
                return View(contact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}

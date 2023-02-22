using Microsoft.AspNetCore.Mvc;
using Module5_Ord.Models;
using System.Linq;

namespace Module5_Ord.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        //public IActionResult Index()
        //{
        //    return RedirectToAction("List");
        //}
        //[Route("[area]/Contact/{id?}")]
        //public IActionResult List()
        //{
        //    var contacts = context.Contacts
        //        .OrderBy(c => c.ContactId).ToList();
        //    return View(contacts);
        //}
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Contact());
        }

        [HttpPost]
        public IActionResult Update(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                {
                    context.Contacts.Add(contact);
                }
                else
                {
                    context.Contacts.Update(contact);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = "Save";
                return View("AddUpdate");
            }
        }
        //public IActionResult Add(Contact contact)
        //{
        //    context.Contacts.Add(contact);
        //    context.SaveChanges();
        //    return RedirectToAction("Index", "Home");
        //}
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
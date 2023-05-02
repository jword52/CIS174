using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectComicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectComicsWebApp.Areas.AdminUser.Controllers
{
    [Area("AdminUser")]
    public class ComicController : Controller
    {
        //repository setup
        private IRepository<Comic> comic { get; set; }
        private IRepository<Review> review { get; set; }
        private IRepository<User> user { get; set; }
        public ComicController(IRepository<Comic> ctxComic, IRepository<Review> ctxReview, IRepository<User> ctxUser)
        {
            comic = ctxComic;
            review = ctxReview;
            user = ctxUser;
        }

        //returns a view of a comic by its id
        [Route("AdminUser/Comic/View")]
        [HttpGet]
        public IActionResult View(int id)
        {
            Comic g = comic.Get(id);

            return View(g);
        }

        //returns the edit comic action with a new comic
        [Route("AdminUser/Comic/Add")]
        public IActionResult Add()
        {
            return View("Edit", new Comic());
        }

        //allows users to add or edit comics, returns the comic edit page 
        [Route("AdminUser/Comic/Edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Console.WriteLine("Admin Comic Edit Request");
            var g = comic.Get(id);
            return View(g);
        }

        //saves the changes to the database if the model state is valid
        [Route("AdminUser/Comic/Edit")]
        [HttpPost]
        public IActionResult Edit(Comic g)
        {
            Console.WriteLine("Admin Comic Edit Response");
            if (ModelState.IsValid)
            {
                if (g.ComicId == 0)
                {
                    g.Rating = 0;
                    g.TotalReviews = 0;
                    comic.Insert(g);
                }
                else
                {
                    comic.Update(g);
                }
                comic.Save();
                ViewBag.FailEdit = "";
                return View("View", g);
            }
            else
            {
                Console.WriteLine("Admin Comic Edit Response Failed");
                ViewBag.FailEdit = "Could not edit comic. Please try again.";
                return View(g);
            }
        }

        //allows verified users to delete comics from the database, returns confirmation page
        [Route("AdminUser/Comic/Delete")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("Admin Comic Delete Request");
            var g = comic.Get(id);
            return View(g);
        }

        //once confirmed, the database removes the comic and all its reviews from the database
        [Route("AdminUser/Comic/Delete")]
        [HttpPost]
        public IActionResult Delete(Comic g)
        {
            Console.WriteLine("Admin Comic Delete Response");
            var reviews = review.List(new QueryOptions<Review> { Where = r => r.ComicId == g.ComicId });
            foreach (Review r in reviews)
            {
                review.Delete(r);
            }
            comic.Delete(g);
            comic.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}
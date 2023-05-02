using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectComicsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectComicsWebApp.Controllers
{
    public class ReviewController : Controller
    {
        //repo setup
        private IRepository<Comic> comic { get; set; }
        private IRepository<Review> review { get; set; }
        private IRepository<User> user { get; set; }
        public ReviewController(IRepository<Comic> ctxComic, IRepository<Review> ctxReview, IRepository<User> ctxUser)
        {
            comic = ctxComic;
            review = ctxReview;
            user = ctxUser;
        }

        //returns a list of reviews based on sort parameters
        [HttpGet]
        public IActionResult List(int id, string sortOrder)
        {
            Console.WriteLine("Unauthenticated Review List Request");
            ViewBag.UserSortParm = String.IsNullOrEmpty(sortOrder) ? "user_desc" : "";
            ViewBag.RatingSortParm = sortOrder == "rating_desc" ? "rating" : "rating_desc";
            ViewBag.SortOrder = sortOrder;

            CurrentComic.Current = comic.Get(id);
            ViewBag.ComicTitle = CurrentComic.Current.Title;
            ViewBag.ComicId = CurrentComic.Current.ComicId;

            IEnumerable<Review> reviews;
            switch (sortOrder)
            {
                case "user_desc":
                    reviews = review.List(new QueryOptions<Review> { Includes = "Comic, User", Where = r => r.ComicId == id, OrderBy = r => r.User.UserName, OrderByDirection = "dsc" });
                    break;
                case "rating":
                    reviews = review.List(new QueryOptions<Review> { Includes = "Comic, User", Where = r => r.ComicId == id, OrderBy = r => r.Rating });
                    break;
                case "rating_desc":
                    reviews = review.List(new QueryOptions<Review> { Includes = "Comic, User", Where = r => r.ComicId == id, OrderBy = r => r.Rating, OrderByDirection = "dsc" });
                    break;
                default:
                    reviews = review.List(new QueryOptions<Review> { Includes = "Comic, User", Where = r => r.ComicId == id, OrderBy = r => r.User.UserName });
                    break;
            }
            return View(reviews);
        }

        //views a single review
        [HttpGet]
        public IActionResult View(int id)
        {
            Console.WriteLine("Unauthenticated Review View Request");
            Review re = null;
            var reviews = review.List(new QueryOptions<Review> { Includes = "User, Comic", Where = r => r.ReviewId == id });
            foreach (Review r in reviews)
            {
                re = r;
            }

            return View(re);
        }
    }
}
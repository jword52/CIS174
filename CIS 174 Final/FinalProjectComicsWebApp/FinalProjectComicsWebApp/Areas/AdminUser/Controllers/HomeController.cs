using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjectComicsWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectComicsWebApp.Areas.AdminUser.Controllers
{
    [Area("AdminUser")]
    public class HomeController : Controller
    {
        //Update() refreshes the database every time a user returns to the main menu in order to see if any new 
        //reviews or changes in rating occur
        private void Update()
        {
            var comics = comic.List(new QueryOptions<Comic> { });
            foreach (Comic g in comics)
            {
                double totalRating = 0;
                int totalReviews = 0;
                var reviews = review.List(new QueryOptions<Review> { Includes = "User, Comic", Where = r => r.ComicId == g.ComicId });
                foreach (Review r in reviews)
                {
                    totalRating += (double)r.Rating;
                    totalReviews += 1;
                }
                if (totalReviews == 0)
                {
                    g.Rating = 0;
                    g.TotalReviews = 0;
                }
                else
                {
                    totalRating = totalRating / totalReviews;
                    g.Rating = totalRating;
                    g.TotalReviews = totalReviews;
                }
                comic.Update(g);
            }
            comic.Save();
        }

        //repository setup
        private IRepository<Comic> comic { get; set; }
        private IRepository<Review> review { get; set; }
        private IRepository<User> user { get; set; }
        public HomeController(IRepository<Comic> ctxComic, IRepository<Review> ctxReview, IRepository<User> ctxUser)
        {
            comic = ctxComic;
            review = ctxReview;
            user = ctxUser;
        }

        //takes in sorting parameters and returns a sorted list of comics
        [Route("AdminUser")]
        public IActionResult Index(string sortOrder)
        {
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.RatingSortParm = sortOrder == "rating_desc" ? "rating" : "rating_desc";
            ViewBag.ReviewSortParm = sortOrder == "review_desc" ? "review" : "review_desc";
            ViewBag.SortOrder = sortOrder;
            Update();
            if (CurrentUser.Current != null)
            {
                ViewBag.UserName = CurrentUser.Current.UserName;
            }
            IEnumerable<Comic> comics;
            switch (sortOrder)
            {
                case "title_desc":
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.Title, OrderByDirection = "dsc" });
                    break;
                case "rating":
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.Rating });
                    break;
                case "rating_desc":
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.Rating, OrderByDirection = "dsc" });
                    break;
                case "review":
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.TotalReviews });
                    break;
                case "review_desc":
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.TotalReviews, OrderByDirection = "dsc" });
                    break;
                default:
                    comics = comic.List(new QueryOptions<Comic> { OrderBy = g => g.Title });
                    break;
            }
            return View(comics);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Module5_Ord.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Module5_Ord.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Custom/[controller]/[action]")]
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            return Content("Admin Controller!");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Module5_Ord.Controllers
{
    public class ExampleController3 : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Example Controller 3, Action Index");
        }

        [Route("About")]
        public IActionResult About()
        {
            return Content("Example Controller 3, Action About");
        }
    }
}
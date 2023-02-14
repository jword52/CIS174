using Microsoft.AspNetCore.Mvc;

namespace Module5_Ord.Controllers
{
    public class ExampleController2 : Controller
    {
        
        public IActionResult Index(string id = "index", int page = 4)
        {
            return Content("Example Controller 2, Action Index, id: " + id + " page: " + page.ToString());
        }
    }
}
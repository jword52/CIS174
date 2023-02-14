using Microsoft.AspNetCore.Mvc;

namespace Module5_Ord.Controllers
{
    public class ExampleController1 : Controller
    {
        [Route("Contacts/{name?}")]
        public IActionResult Index()
        {
            return Content("Example Controller 1");
        }
        [Route("Contact/id")]
        public IActionResult Post(string id = "all")
        {
            return Content("Example Controller , Post action, id " + id);
        }
    }
}
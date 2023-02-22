using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module5_Ord.Models;
using System.Collections.Generic;
using System.Linq;

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
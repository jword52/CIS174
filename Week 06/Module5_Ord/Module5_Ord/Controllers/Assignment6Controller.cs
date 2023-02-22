using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


using System.Linq;
using Module5_Ord.Models;

namespace Module5_Ord.Controllers
{
    public class Assignment6Controller : Controller
    {
        public ActionResult Index(int accessLevel)
        {
            var students = new List<Student>
            {
                new Student { FirstName = "Peter", LastName = "Parker", Grade = "A" },
                new Student { FirstName = "Clark", LastName = "Kent", Grade = "B" },
                new Student { FirstName = "Steve", LastName = "Rogers", Grade = "A+" },
                new Student { FirstName = "Hal", LastName = "Jordan", Grade = "C+" },
                new Student { FirstName = "Miles", LastName = "Morales", Grade = "B-" },
                new Student { FirstName = "Diana", LastName = "Prince", Grade = "C+" }
            };

            var viewModel = new Assignment6ViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View(viewModel);
        }
    }
}
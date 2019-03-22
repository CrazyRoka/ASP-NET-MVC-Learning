using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLearning.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCLearning.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult ContentDemo() => Content("Hello, World", "text/plain");

        public IActionResult JsonDemo()
        {
            var m = new Menu
            {
                Id = 3,
                Text = "Grilled sausage with sauerkraut and potatoes",
                Price = 12.90,
                Date = new DateTime(2018, 3, 31),
                Category = "Main"
            };
            return Json(m);
        }

        public IActionResult RedirectDemo() => Redirect("https://www.google.com");

        public IActionResult RedirectRouteDemo() => RedirectToRoute(new { controller = "Home", action = "Hello" });

        public IActionResult FileDemo() => File("~/images/Matthias.jpg", "image/jpeg");
    }
}

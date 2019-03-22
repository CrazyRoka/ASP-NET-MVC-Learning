using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCLearning.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCLearning.Controllers
{
    public class ViewsDemoController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult PassingData()
        {
            ViewBag.MyData = "Hello from the controller";
            return View();
        }

        private IEnumerable<Menu> GetSampleData() =>
            new List<Menu>
            {
                new Menu
                {
                    Id=1,
                    Text="Schweinsbraten mit Knödel und Sauerkraut",
                    Price=6.9,
                    Category="Main"
                },
                new Menu
                {
                    Id=2,
                    Text="Erdäpfelgulasch mit Tofu und Gebäck",
                    Price=6.9,
                    Category="Vegetarian"
                },
                new Menu
                {
                    Id=3,
                    Text="Tiroler Bauerngröst'l mit Spiegelei und Krautsalat",
                    Price=6.9,
                    Category="Main"
                }
            };

        public IActionResult PassingAModel() => View(GetSampleData());

        public IActionResult LayoutSample => View();

        public IActionResult LayoutUsingSections() => View();
    }
}

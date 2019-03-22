using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCLearning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public string Hello() => "Hello, ASP.NET Core MVC";

        public string Greeting(string name) => HtmlEncoder.Default.Encode($"Hello, {name}");

        public string Greeting2(string id) => HtmlEncoder.Default.Encode($"Hello, {id}");

        public int Add(int x, int y) => x + y;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCLearning.Controllers
{
    public class POCOController
    {
        public IActionResult Index() => "this is POCO controller";

        [ActionContext]
        public ActionContext ActionContext { get; set; }

        public HttpContext HttpContext => ActionContext.HttpContext;

        public ModelStateDictionary ModelState => ActionContext.ModelState;

        public string UserAgentInfo()
        {
            if (HttpContext.Request.Headers.ContainsKey("User-Agent"))
            {
                return HttpContext.Request.Headers["User-Agent"];
            }
            return "No user-agent information";
        }
    }
}

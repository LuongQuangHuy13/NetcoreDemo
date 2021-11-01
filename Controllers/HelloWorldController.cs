using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Demo.Controllers
{  public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        
    }
}
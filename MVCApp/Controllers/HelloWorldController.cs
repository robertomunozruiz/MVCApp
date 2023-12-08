using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        /*public string Index()
        {
           return "This is my default action...";
        }*/

        public IActionResult Index()
        {
            return View();
        }

       /*public string Welcome(string name, int numTimes = 1)
        {
            //return "welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, Nuntimes is: {numTimes}");
        }*/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

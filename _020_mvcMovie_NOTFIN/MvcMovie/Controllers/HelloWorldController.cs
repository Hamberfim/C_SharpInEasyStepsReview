using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // public string Index(string name = "Guest", int ID = -1)
        // {
        //     return ($"Hello {name}, ID: {ID}.");
        // }
        public IActionResult Index()
        {
            return View();
        }

        //Requires using System.Text.Encodings.Web;
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name = "Guest", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"This is the Welcome action method...Hello {name}, NumTimes is: {numTimes}.");
        }


        // Requires using System.Text.Encodings.Web;
        // Get /HelloWorld/BeGone/
        public string BeGone(string name = "Guest", int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"This is the BeGone action method...Hello {name}, NumTimes is: {numTimes}.");
        }
    }
}

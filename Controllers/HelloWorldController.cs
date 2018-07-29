using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AspCoreMvc.Controllers
{
    public class TestController : Controller
    {
        // 
        // GET: /Test/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Test/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}
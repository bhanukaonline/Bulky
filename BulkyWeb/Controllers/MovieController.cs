using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Movies() 
        {
            return View();
        }
    }
}

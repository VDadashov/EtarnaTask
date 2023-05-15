using Microsoft.AspNetCore.Mvc;

namespace Etarna.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

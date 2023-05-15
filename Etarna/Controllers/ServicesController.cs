using Microsoft.AspNetCore.Mvc;

namespace Etarna.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

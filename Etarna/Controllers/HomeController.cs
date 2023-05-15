using Etarna.DataAccessLayer;
using Etarna.ViewModel.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etarna.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM
            {
                Featureds = await _context.Featureds
                .Where(f=>f.IsDeleted == false).ToListAsync(),
                Services = await _context.Services
                .Where(s=>s.IsDeleted == false).ToListAsync()
            };

            return View(vm);
        }
    }
}

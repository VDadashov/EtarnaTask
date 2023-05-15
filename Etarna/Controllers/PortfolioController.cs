using Etarna.DataAccessLayer;
using Etarna.Models;
using Etarna.ViewModel.Portfolio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etarna.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            PortfolioVm vm = new PortfolioVm
            {
                PortfolioDetails = await _context.PortfolioDetails
                .Where(p => p.IsDeleted == false)
                .Include(p => p.PortfolioDetailAndClientAndImageRelationManyToManies)
                .ThenInclude(p => p.PortfolioImage)
                .ToListAsync(),
                PortfolioImages = await _context.PortfolioImages
                .Where(p => p.IsDeleted == false)
                .ToListAsync(),
                 Clients = await _context.Clients
                .Where(p => p.IsDeleted == false)
                .ToListAsync()
            };

            return View(vm);
        }

        public async Task<IActionResult> Detail(int id)
        {
            PortfolioVm vm = new PortfolioVm
            {
                PortfolioDetails = await _context.PortfolioDetails
                .Where(p => p.IsDeleted == false)
                .Include(p => p.PortfolioDetailAndClientAndImageRelationManyToManies)
                .ThenInclude(p => p.PortfolioImage)
                .ToListAsync(),
                PortfolioImages = await _context.PortfolioImages
                .Where(p => p.IsDeleted == false)

                .ToListAsync(),
                Clients = await _context.Clients
                .Where(p => p.IsDeleted == false)
                .ToListAsync()
            };

            if (id == null) BadRequest();

            PortfolioDetail portfolioDetail = vm.PortfolioDetails.FirstOrDefault(p=>p.Id == id);

            if (portfolioDetail == null) NotFound();

            return View(portfolioDetail);
        }
    }
}

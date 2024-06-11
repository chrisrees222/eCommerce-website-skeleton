using eCommerce_website_skeleton.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Controllers
{
    public class CinemasControllers : Controller
    {
        private readonly AppDbContext _context;

        public CinemasControllers(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}

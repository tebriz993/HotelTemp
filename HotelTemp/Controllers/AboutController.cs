using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class AboutDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public AboutDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<About> about = _context.About.ToList();
            return View(about);
        }
    }
}

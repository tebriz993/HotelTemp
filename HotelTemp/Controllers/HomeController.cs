using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace HotelTemp.Controllers
{
    public class HomeDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public HomeDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Home> home = _context.Home.ToList();
            return View(home);
        }
    }

}

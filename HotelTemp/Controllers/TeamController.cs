using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class TeamDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public TeamDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Team> team = _context.Team.ToList();
            return View(team);
        }
    }
}

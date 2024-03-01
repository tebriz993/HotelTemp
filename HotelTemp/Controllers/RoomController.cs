using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class RoomDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public RoomDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Room> rooms = _context.Room.ToList();
            return View(rooms);
        }
    }
}

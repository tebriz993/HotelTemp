using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{ 
    public class ServiceDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public ServiceDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Service.ToList();
            return View(services);
        }
    }
}

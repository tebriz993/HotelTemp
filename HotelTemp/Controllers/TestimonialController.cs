using HotelTemp.Data;
using HotelTemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class TestimonialDbContext : Controller
    {
        private readonly HotelTempDbContext _context;

        public TestimonialDbContext(HotelTempDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Testimonial> testimonial = _context.Testimonial.ToList();
            return View(testimonial);
        }
    }
}

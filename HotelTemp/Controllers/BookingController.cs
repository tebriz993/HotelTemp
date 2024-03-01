using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

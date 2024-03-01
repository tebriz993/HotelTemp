using Microsoft.AspNetCore.Mvc;

namespace HotelTemp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        //admin: Fatmanur şifre:1111
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            var newEntrance=_context.Admins.Where(x=>x.AdminName == admin.AdminName && x.AdminPassword==admin.AdminPassword).FirstOrDefault();
            // var entrance = from x in _context.Admins where admin.AdminName == x.AdminName && admin.AdminPassword == x.AdminPassword select x;entrance.Count() > 0)
            if (newEntrance==null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Category");
            }
        }
        //public IActionResult Home()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Home(Admin admin)
        //{
        //    return View("Index", "Admin");
        //}
    }
}

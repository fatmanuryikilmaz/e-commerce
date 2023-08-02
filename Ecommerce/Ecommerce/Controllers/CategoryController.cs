using DocumentFormat.OpenXml.Office.CustomUI;
using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult CategoryPage(int id)
        {
            var category = _context.Products.Where(x => x.CategoryID == id).ToList();
            return View(category);
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //edit
        public IActionResult Edit(int id)
        {
            var edit = _context.Categories.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int id,Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //delete
        public IActionResult Delete(int id)
        {
            var delete = _context.Categories.Find(id);
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(int id,Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //details
        public ActionResult Details(int id)
        {
            var Urun = _context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            return View(Urun);
        }

        
    }
}

using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }
        public IActionResult Create()
        {
            var Category=_context.Categories.ToList();
            ViewBag.Categories = new SelectList(Category, "CategoryID", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
           
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //edit
        public IActionResult Edit(int id)
        {
            var edit = _context.Products.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //delete
        public IActionResult Delete(int id)
        {
            var delete = _context.Products.Find(id);
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(int id, Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //details
        public IActionResult Details(int id)
        {
            var product = _context.Products.Where(x => x.ProductID == id).FirstOrDefault();
            return View(product);
        }
        public IActionResult ProductDetail(int id)
        {
            return View(_context.Products.Where(x=>x.ProductID==id).FirstOrDefault());
        }
    }
}

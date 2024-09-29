using envatomarket1.Data;
using envatomarket1.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace envatomarket1.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationContext _context;
        public BlogController(ApplicationContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var Blogs=_context.Blogs.ToList();
            return View(Blogs);
        }

        [HttpGet("id")]
        public IActionResult Details(int id) 
        {
            var Blog=_context.Blogs.Find(id);
            if (Blog == null) NoContent();
            return View(Blog);
        }

        [HttpPost]
        public IActionResult Create(Blog blog) 
        {
             _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            var Blog=_context.Blogs.Find(id);
            if (Blog == null) NoContent();
            _context.RemoveRange();
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
            
    }
}

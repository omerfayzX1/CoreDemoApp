using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            var values = blogManager.GetBlogById(id);
            return View(values);
        }
    }
}

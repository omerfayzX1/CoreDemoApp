using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class Category : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

     
        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
    }
}

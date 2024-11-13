using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

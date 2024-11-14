using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class AboutController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

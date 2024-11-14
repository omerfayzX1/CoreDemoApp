using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}

using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager categoryManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
           var values = categoryManager.GetList(id);
            return PartialView(values);
        }
    }
}

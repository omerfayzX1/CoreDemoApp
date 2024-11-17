using Microsoft.AspNetCore.Mvc;

namespace CodeDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

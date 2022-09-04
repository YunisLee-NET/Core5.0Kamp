using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        public PartialViewResult ListCommentByBlog(int id)
        {
            var values = commentManager.TGetList(id);
            return PartialView(values);
        }
    }
}

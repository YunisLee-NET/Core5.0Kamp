using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Bloq_Kamp.Controllers
{
    public class DefaultController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.getid = id;
            var values = blogManager.GetBlogByID(id);
            return View(values);
        }
    }
}

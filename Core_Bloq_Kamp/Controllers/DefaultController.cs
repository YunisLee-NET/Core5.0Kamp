using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult BlogListByWriter()
        {
            var values=blogManager.GetBlogListByWriter(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog b)
        {
            BlogValidation bv = new BlogValidation();
            ValidationResult results = bv.Validate(b);
            if (results.IsValid)
            {
                b.BlogStatus = true;
                b.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                b.WriterID = 1;
                blogManager.TAdd(b);
                return RedirectToAction("BlogListByWriter", "Default");
            }
            else
            {
                foreach (var rule in results.Errors)
                {
                    ModelState.AddModelError(rule.PropertyName, rule.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogdl = blogManager.GetByID(id);
            blogManager.TDelete(blogdl);
            return RedirectToAction("BlogListByWriter", "Default");

        }
    }
}

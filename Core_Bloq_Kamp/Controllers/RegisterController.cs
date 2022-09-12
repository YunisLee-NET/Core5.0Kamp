using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;

namespace Core_Bloq_Kamp.Controllers
{
    public class RegisterController : Controller
    {        
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidation rules = new WriterValidation();
            ValidationResult validationResult = rules.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.TAdd(writer);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                foreach(var rule in validationResult.Errors)
                {
                    ModelState.AddModelError(rule.PropertyName, rule.ErrorMessage);                    
                }
                return View();
            }
        }
    }
}

﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_Bloq_Kamp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer w)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == w.WriterMail && x.WriterPassword == w.WriterPassword);
            if (datavalue != null)
            {
                var telebler = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, w.WriterMail)
                };
                var userid = new ClaimsIdentity(telebler, "a");
                ClaimsPrincipal cp = new ClaimsPrincipal(userid);
                await HttpContext.SignInAsync(cp);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return View();
            }
        }
    }
}

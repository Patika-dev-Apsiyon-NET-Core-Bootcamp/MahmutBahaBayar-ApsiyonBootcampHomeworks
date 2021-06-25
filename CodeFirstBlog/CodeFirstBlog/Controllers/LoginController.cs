using CodeFirstBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Controllers
{
    public class LoginController : Controller
    {
        private readonly BlogContext _context;
        public LoginController(BlogContext context)
        {
            _context = context;
        }

        public ActionResult Login()
        {
            var model = new User();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            User model = _context.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
            if (model != null)
            {
                return RedirectToAction("Index", "Home");

            }

            else
            {
                ViewBag.ErrorMessage = "The username or password is incorrect please try again";
            }
            return View();
        }

    }
}

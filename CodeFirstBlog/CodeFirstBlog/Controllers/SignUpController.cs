using CodeFirstBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Controllers
{
    public class SignUpController : Controller
    {
        private readonly BlogContext _context;
        public SignUpController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction ("Login","Login");
        }

     

    }
}

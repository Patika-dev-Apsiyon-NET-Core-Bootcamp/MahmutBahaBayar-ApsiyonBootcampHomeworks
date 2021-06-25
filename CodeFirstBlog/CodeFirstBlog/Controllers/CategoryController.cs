using CodeFirstBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BlogContext _context;
        public CategoryController(BlogContext context)
        {
            _context = context;
        }
        public  IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAdd(Category category)
        {

         await _context.Categories.AddAsync(category);
         await _context.SaveChangesAsync();
         return RedirectToAction("Add","Blog");
           
        }
    }
}

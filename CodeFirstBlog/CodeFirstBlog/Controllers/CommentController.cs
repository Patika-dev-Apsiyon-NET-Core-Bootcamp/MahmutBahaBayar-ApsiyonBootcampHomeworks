using CodeFirstBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Controllers
{
    public class CommentController : Controller
    {
        private readonly BlogContext _context;
        public CommentController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(int id,Comment comment)
        {
              comment.BlogPostId = id;
            await _context.AddAsync(comment);
            _context.SaveChanges();
            return RedirectToAction( );
        }
    }
}

using AutoMapper;
using CodeFirstBlog.DTOs;
using CodeFirstBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstBlog.Controllers
{
    public class BlogController : Controller
    {

        private readonly BlogContext _context;


        public BlogController(BlogContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Add()
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(BlogPost newBlogPost)
        {

            newBlogPost.IsDeleted = false;
            await _context.AddAsync(newBlogPost);
            _context.SaveChanges();
            return RedirectToAction("Blog", "GetList");
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            List<BlogPost> blogPostList = new List<BlogPost>();
            blogPostList = await _context.BlogPosts.Where(x => (bool)!x.IsDeleted).OrderByDescending(x => x.Id).ToListAsync();

            return View(blogPostList);
        }

        [HttpGet]
        //[Route("Blog/Detail/{blogpostId}")]
        public ActionResult Detail(int Id)
        {


            DetailBlogWithComments mymodel = new DetailBlogWithComments();
            mymodel.Comments = _context.Comments.Where(x => x.BlogPost.Id == Id).ToList();
            mymodel.blogPost = _context.BlogPosts.FirstOrDefault(x => x.Id == Id);

            return View(mymodel);


        }
    }
}

using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService = null;
        private readonly ICategoryService _categoryService = null;
        private readonly ITagService _tagService = null;

        public BlogController(IBlogService blogService, ICategoryService categoryService, ITagService tagService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = _categoryService.GetAll();
            var tags = _tagService.GetAll();
            ViewBag.Categories = categories;
            ViewBag.Tags = tags;
            return View();
        }

        [HttpPost]
        public IActionResult Add(BlogViewModel model)
        {
            //foreach (var id in model.SelectedCategories)
            //{
            //  CategoryViewModel categoryViewModel =  _categoryService.GetById(id)
            //}
            //model.Categories = 
            _blogService.AddWithCategories(model);
            return RedirectToAction("Add");
        }
    }
}

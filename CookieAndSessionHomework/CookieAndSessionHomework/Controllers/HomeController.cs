using CookieAndSessionHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using CookieAndSessionHomework.Constants;

namespace CookieAndSessionHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBook(BookModel book)
        {

            var bookList = SessionExtensionClass.Get<List<BookModel>>(HttpContext.Session, SessionConstants.Book);

            if (bookList == null)
            {
                bookList = new List<BookModel>();
            }

            bookList.Add(book);

            SessionExtensionClass.Set<List<BookModel>>(HttpContext.Session, SessionConstants.Book, bookList);

            return Ok();
        }

        [HttpGet]

        public IActionResult GetBookList()
        {
            var bookList = SessionExtensionClass.Get<List<BookModel>>(HttpContext.Session, SessionConstants.Book);
            return View("GetBookList", bookList);
        }




        [HttpGet]
        public IActionResult GetBookListByName(string bookName)
        {
            var bookList = SessionExtensionClass.Get<List<BookModel>>(HttpContext.Session, SessionConstants.Book);
            BookModel book = new BookModel();
            book = bookList.Find(x => x.BookName == bookName);
            if (book != null)
            {
                return View("GetBookList",book);
            }

            ViewBag.NotFound = $"There is no book named like {bookName}";
            return View();          
        }
    }
}

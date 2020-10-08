using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMVC.Controllers
{
    public class BookController : Controller
    {

        private readonly MySQLContext db;

        public BookController(MySQLContext context)
        {
            db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult All()
        {
            ViewBag.books = db.Books.ToList();
            return View();
        }

        public IActionResult NewBook()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult NewBook(string title)
        {
            Book book = new Book(title);
            db.Books.Add(book);
            db.SaveChanges();

            return RedirectToAction(actionName: "All", controllerName: "Book");
        }

        [HttpGet]
        public RedirectToActionResult DeleteBook(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();

            return RedirectToAction(actionName: "All", controllerName: "Book");
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            ViewBag.book = db.Books.Find(id);

            return View();
        }

        [HttpPost]
        public RedirectToActionResult EditBook(int id, string title)
        {
            Book book = db.Books.Find(id);
            book.Title = title;
            db.SaveChanges();

            return RedirectToAction(actionName: "All", controllerName: "Book");
        }
    }
}

using BookLibrary.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var books = _bookService.GetAll();  

            return View(books);
        }
    }
}

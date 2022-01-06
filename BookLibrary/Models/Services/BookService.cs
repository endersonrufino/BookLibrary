using BookLibrary.Models.Interfaces.Repositories;
using BookLibrary.Models.Interfaces.Services;
using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookViewModel> GetAll()
        {
            return _bookRepository.GetAll();
        }
    }
}

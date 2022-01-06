using BookLibrary.Models.Interfaces.Repositories;
using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<BookViewModel> GetAll()
        {
            List<BookViewModel> books = ContextDataFake.Books;

            return books;
        }
    }
}

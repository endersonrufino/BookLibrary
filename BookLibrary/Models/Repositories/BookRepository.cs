using BookLibrary.Models.Contexts;
using BookLibrary.Models.Interfaces.Contexts;
using BookLibrary.Models.Interfaces.Repositories;
using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IContextData _contextData;

        public BookRepository(IContextData contextData)
        {
            _contextData = contextData;
        }
        public List<BookViewModel> GetAll()
        {
            List<BookViewModel> books = _contextData.GetAll();

            return books;
        }
    }
}

using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Interfaces.Contexts
{
    public interface IContextData
    {
        void AddBook(BookViewModel book);
        void UpdateBook(BookViewModel book);
        void DeleteBook(BookViewModel book);
        List<BookViewModel> GetAll();
        BookViewModel GetBook(int id);
    }
}

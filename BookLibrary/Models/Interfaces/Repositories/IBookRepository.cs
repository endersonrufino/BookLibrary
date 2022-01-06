using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Interfaces.Repositories
{
    public interface IBookRepository
    {
        List<BookViewModel> GetAll();
    }
}

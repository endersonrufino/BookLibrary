using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Interfaces.Services
{
    public interface IBookService
    {
        List<BookViewModel> GetAll();
    }
}

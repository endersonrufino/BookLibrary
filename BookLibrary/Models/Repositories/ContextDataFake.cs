using BookLibrary.Models.ViewModels;

namespace BookLibrary.Models.Repositories
{
    public static class ContextDataFake
    {
        public static List<BookViewModel> Books { get; set; }

        static ContextDataFake()
        {
            Books = new List<BookViewModel>();

            InitializeData();
        }

        private static void InitializeData()
        {
            BookViewModel book = new BookViewModel(
                "teste titulo 1",
                "teste autor 1",
                "teste editora 1"
                );
            Books.Add(book);

            book = new BookViewModel(
               "teste titulo 2",
               "teste autor 2",
               "teste editora 2"
               );
            Books.Add(book);

            book = new BookViewModel(
               "teste titulo 3",
               "teste autor 3",
               "teste editora 3"
               );
            Books.Add(book);

            book = new BookViewModel(
               "teste titulo 4",
               "teste autor 4",
               "teste editora 4"
               );
            Books.Add(book);
        }
    }
}
namespace BookLibrary.Models.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string PublishingCompany { get; set; }

        public BookViewModel(int Id, string Name, string Author, string PublishingCompany)
            :this(Name, Author, PublishingCompany)
        {
            this.Id = Id;            
        }

        public BookViewModel(string Name, string Author, string PublishingCompany)
        {           
            this.Name = Name;
            this.Author = Author;
            this.PublishingCompany = PublishingCompany;            
        }
    }
}
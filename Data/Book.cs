using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Bibliotech0.Data
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public long Isbn { get; set; }
        public string Location { get; set; }
        public string IsAvailable { get; set; }

        public Book() { }

        public Book(int id, string title, string authorFirstName, string authorLastName, long isbn, string location, string isAvailable)
        {
            ID = id;
            Title = title;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            Isbn = isbn;
            Location = location;
            IsAvailable = isAvailable;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogue
{
    public class Author
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Author()
        {
            firstName = "";
            lastName = "";
        }
    }

    public class Book
    {
        public string title { get; set; }
        public int year { get; set; }
        public List<Author> authors { get; set; }
        public List<string> categories { get; set; }
        public List<string> genres { get; set; }
        public string publisher { get; set; }
        public Book()
        {
            title = "";
            year = 0;
            authors = new List<Author>();
            categories = new List<string>();
            genres = new List<string>();
            publisher = "";
        }
    }

    public class Library
    {
        public List<Book> books { get; set; }
        public Library()
        {
            books = new List<Book>();
        }
    }


}

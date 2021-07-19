using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LibraryCatalogue
{
    public partial class LibraryCatalogue : Form
    {
        Author newAuthor;
        Book newBook;
        Library library;
        string data;
        string fileName;
        public LibraryCatalogue()
        {
            InitializeComponent();
            newAuthor = new Author();
            newBook = new Book();
            library = new Library();
            fileName = "../../data.json";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            newAuthor.firstName = "Todor";
            newAuthor.lastName = "Todorov";
            newBook.title = "Some Title";
            newBook.year = 2020;
            newBook.authors.Add(newAuthor);
            newBook.categories.Add("Roman");
            newBook.genres.Add("Fiction");
            newBook.publisher = "Pingvin";

            library.books.Add(newBook);
            string ser = JsonConvert.SerializeObject(library);
            File.WriteAllText(fileName, ser);
            Console.WriteLine(File.ReadAllText(fileName));

        }

        private void LibraryCatalogue_Load(object sender, EventArgs e)
        {
            
            data = File.ReadAllText(fileName);
            library = JsonConvert.DeserializeObject<Library>(data);

/*            newAuthor.firstName = "Todor";
            newAuthor.lastName = "Todorov";
            newBook.title = "Some Title";
            newBook.year = 2020;
            newBook.authors.Add(newAuthor);
            newBook.categories.Add("Roman");
            newBook.genres.Add("Fiction");
            newBook.publisher = "Pingvin";

            library.books.Add(newBook);*/

/*            foreach (Book bk in library.books)
            {
                Console.WriteLine(bk.title);
                Console.WriteLine(bk.year);
                foreach (Author au in bk.authors)
                {
                    Console.WriteLine(au.firstName);
                    Console.WriteLine(au.lastName);
                }
                foreach (string ca in bk.categories)
                {
                    Console.WriteLine(ca);
                }
                foreach (string gn in bk.genres)
                {
                    Console.WriteLine(gn);
                }
                Console.WriteLine(bk.publisher);
            }*/
        }
    }
}

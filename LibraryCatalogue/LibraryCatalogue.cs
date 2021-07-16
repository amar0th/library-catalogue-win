using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalogue
{
    public partial class LibraryCatalogue : Form
    {
        public LibraryCatalogue()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void LibraryCatalogue_Load(object sender, EventArgs e)
        {
            Author newAuthor = new Author();
            newAuthor.firstName = "Todor";
            newAuthor.lastName = "Todorov";
            Book newBook = new Book();
            newBook.title = "Some Title";
            newBook.year = 2020;
            newBook.authors.Add(newAuthor);
            newBook.categories.Add("Roman");
            newBook.genres.Add("Fiction");
            newBook.publisher = "Pingvin";
            Library library = new Library();
            library.books.Add(newBook);

            foreach (Book bk in library.books)
            {
                Console.WriteLine(bk.title);
            }
        }
    }
}

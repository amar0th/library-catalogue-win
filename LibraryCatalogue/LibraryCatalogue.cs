using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

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
            library = new Library();
            InitializeComponent();
            fileName = String.Format("{0}/LibraryCatalogue/data.json", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        }

        private void submit_Click(object sender, EventArgs e)
        {
            newAuthor = new Author();
            newBook = new Book();
            try
            {
                newAuthor.firstName = firstName.Text;
                newAuthor.lastName = lastName.Text;
                newBook.title = title.Text;
                newBook.year = Int32.Parse(year.Text);
                newBook.authors.Add(newAuthor);
                newBook.categories.Add("");
                newBook.genres.Add("");
                newBook.publisher = publisher.Text;

                library.books.Add(newBook);

                string ser = JsonConvert.SerializeObject(library, Formatting.Indented);
                File.WriteAllText(fileName, ser);
                Console.WriteLine(File.ReadAllText(fileName));
                ClearAllText(this);
                success.Text = "Книгата е успешно запазена!";
                success.Visible = true;
                var t = new Timer
                {
                    Interval = 2000
                };
                t.Tick += (s, ev) =>
                {
                    success.Visible = false;
                }; t.Start();
            }
            catch(Exception exc)
            {
                warning.Text = String.Format("Изникна грешка при запазване! Съобщение:\n{0}", exc.Message);
                warning.Visible = true;
                var t = new Timer
                {
                    Interval = 2000
                };
                t.Tick += (s, ev) =>
                {
                    this.warning.Visible = false;
                }; t.Start();
            }
        }

        private void LibraryCatalogue_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo.CurrentUICulture = new CultureInfo("bg-BG");

            data = File.ReadAllText(fileName);
            library = JsonConvert.DeserializeObject<Library>(data);
        }


        private void clear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            ListOfBooks list = new ListOfBooks();

            list.Show();
        }
    }
}

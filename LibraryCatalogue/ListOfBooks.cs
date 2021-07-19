using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryCatalogue
{
    public partial class ListOfBooks : Form
    {
        private readonly string fileName = "../../data.json";

        public ListOfBooks()
        {
            InitializeComponent();
        }

        protected private void HandleData()
        {
            string data = File.ReadAllText(fileName);
            Library library = JsonConvert.DeserializeObject<Library>(data);

            int lastTopPos = 5;

            for (int i = 0; i < library.books.Count; i++)
            {
                //Current book we are looping through
                Book currentBook = library.books[i];

                /*Book Panel*/
                Panel panel = new Panel
                {
                    Parent = new ListOfBooks(),
                    Top = lastTopPos,
                    Left = 5,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                panel.Width = panel.Parent.Width - 40;

                lastTopPos += panel.Height + 10;

                /*Book Title*/
                Label bookTitle = new Label
                {
                    AutoSize = true,
                    Parent = panel,
                    Text = currentBook.title,
                    Font = new Font(FontFamily.GenericSansSerif, (float)10, FontStyle.Bold)
                };

                bookTitle.Left = bookTitle.Parent.Left + 5;
                bookTitle.Top = bookTitle.Parent.Top + 5;

                /*Author Details*/
                string cachedAuthors = "";
                for (int j = 0; j < currentBook.authors.Count; j++)
                {
                    cachedAuthors += String.Format("{0} {1}, ", currentBook.authors[j].firstName, currentBook.authors[j].lastName);

                    if (j == currentBook.authors.Count - 1)
                    {
                        cachedAuthors = cachedAuthors.Remove(cachedAuthors.Length - 2, 1);
                    }
                }

                Label authorLabel = new Label
                {
                    AutoSize = true,
                    Parent = panel,
                    Text = cachedAuthors,
                };

                authorLabel.Left = authorLabel.Parent.Left + 5;
                authorLabel.Top = authorLabel.Parent.Top + 25;

                Controls.Add(authorLabel);

                string cachedCategories = "";
                for (int j = 0; j < currentBook.categories.Count; j++)
                {
                    cachedCategories += String.Format("{0}, ", currentBook.categories[j]);

                    if (j == currentBook.categories.Count - 1)
                    {
                        cachedCategories = cachedCategories.Remove(cachedCategories.Length - 2, 1);
                    }
                }

                Label bookCategory = new Label
                {
                    AutoSize = true,
                    Parent = panel,
                    Text = cachedCategories
                };

                bookCategory.Left = bookCategory.Parent.Left + 5;
                bookCategory.Top = bookCategory.Parent.Top + 65;

                string cachedGenres = "";
                for (int j = 0; j < currentBook.genres.Count; j++)
                {
                    cachedGenres += String.Format("{0}, ", currentBook.genres[j]);

                    if (j == currentBook.genres.Count - 1)
                    {
                        cachedGenres = cachedGenres.Remove(cachedGenres.Length - 2, 1);
                    }
                }

                Label bookGenre = new Label
                {
                    AutoSize = true,
                    Parent = panel,
                    Text = cachedGenres
                };

                bookGenre.Left = bookGenre.Parent.Left + 5;
                bookGenre.Top = bookGenre.Parent.Top + 80;

                Label publisherYear = new Label
                {
                    AutoSize = true,
                    Parent = panel,
                    Text = String.Format("{0} - {1}", currentBook.publisher, currentBook.year)
                };

                publisherYear.Left = publisherYear.Parent.Right - publisherYear.Width - 5;
                publisherYear.Top = publisherYear.Parent.Top + 80;

                Controls.Add(bookGenre);
                Controls.Add(bookCategory);
                Controls.Add(publisherYear);
                Controls.Add(bookTitle);
                Controls.Add(panel);
            }

        }

        private void ListOfBooks_Load(object sender, EventArgs e)
        {
            HandleData();
        }
    }
}

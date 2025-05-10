using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Library lib = new Library();
        //Book newBook = new Book(0.ToString(), 0.ToString(), 0, 0.ToString());

        Dictionary<string, Book> bookDictionary = new Dictionary<string, Book>();

        string filePath = "books.txt";

        public Form1()
        {
            InitializeComponent();
            LoadBooksFromFile(filePath);
        }

        public bool is_in(List<Book> list, string comp)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                if (comp == list[0].ISBN.ToString())
                    return true;
            }
            return false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (lib.books.Count != null || lib.books.Count != 0)
            {
                if (!is_in(lib.books, txtISBN.Text))
                {
                    //newBook.Title = txtTitle.Text;
                    //newBook.Author = txtAuthor.Text;
                    //newBook.Year = Convert.ToInt32(txtYear.Text);
                    //newBook.ISBN = txtISBN.Text;
                    Book newBook = new Book(txtTitle.Text, txtAuthor.Text, Convert.ToInt32(txtYear.Text), txtISBN.Text);

                    lib.AddBook(newBook);
                    lbLibrary.Items.Add(newBook.Title);
                    bookDictionary[newBook.Title] = newBook;

                    MessageBox.Show("Book added successfully!");
                }
                else
                {
                    MessageBox.Show("There is already a book with this code ISBN");
                }
            }
        }

        private void library_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLibrary.SelectedItem != null)
            {
                string selectedTitle = lbLibrary.SelectedItem.ToString();
                if (bookDictionary.TryGetValue(selectedTitle, out Book selectedBook))
                {
                    txtTitle.Text = selectedBook.Title;
                    txtAuthor.Text = selectedBook.Author;
                    txtYear.Text = selectedBook.Year.ToString();
                    txtISBN.Text = selectedBook.ISBN;
                }
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lbLibrary.SelectedItem != null)
            {
                string selectedTitle = lbLibrary.SelectedItem.ToString();

                if (bookDictionary.TryGetValue(selectedTitle, out Book selectedBook))
                {
                    lib.RemoveBook(selectedBook);

                    lbLibrary.Items.Remove(selectedTitle);

                    bookDictionary.Remove(selectedTitle);

                    txtTitle.Text = "";
                    txtAuthor.Text = "";
                    txtYear.Text = "";
                    txtISBN.Text = "";
                }
            }
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            string searchTitle = txtSearchByTitle.Text.Trim();
            if (!string.IsNullOrEmpty(searchTitle))
            {
                lbLibrary.Items.Clear();

                var foundBooks = lib.SearchByTitle(searchTitle);
                foreach (var book in foundBooks)
                {
                    lbLibrary.Items.Add(book.Title);
                }
            }
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            string searchAuthor = txtSearchByAuthor.Text.Trim();
            if (!string.IsNullOrEmpty(searchAuthor))
            {
                lbLibrary.Items.Clear();

                var foundBooks = lib.SearchByAuthor(searchAuthor);
                foreach (var book in foundBooks)
                {
                    lbLibrary.Items.Add(book.Title);
                }
            }
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            lbLibrary.Items.Clear();

            var allBooks = lib.GetAllBooks();
            foreach (var book in allBooks)
            {
                lbLibrary.Items.Add(book.Title);
            }
        }

        private void SaveBooksToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in lib.GetAllBooks())
                {
                    writer.WriteLine($"{book.Title}|{book.Author}|{book.Year}|{book.ISBN}");
                }
            }
        }

        private void LoadBooksFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            Book book = new Book(parts[0], parts[1], int.Parse(parts[2]), parts[3]);
                            lib.AddBook(book);
                            lbLibrary.Items.Add(book.Title);
                            bookDictionary[book.Title] = book;
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBooksToFile(filePath);
            MessageBox.Show("Books saved successfully.");
        }
    }
}

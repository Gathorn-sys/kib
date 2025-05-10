using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public interface ILibrary
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        void RemoveBook(Book book);
        List<Book> SearchByAuthor(string author);
        List<Book> SearchByTitle(string title);
    }
}
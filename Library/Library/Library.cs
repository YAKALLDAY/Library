using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManager;
using Library.Book;
using Library.Person;


namespace Library.Library
{
    internal abstract class Library
    {

        public List<Book.Book> books;
        protected void AddBook(Book.Book book)
        {
            books.Add(book);
        }
        protected void RemoveBook(Book.Book book)
        {
            books.Remove(book);
        }
    }
}

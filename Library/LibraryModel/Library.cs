using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManagerModel;
using Library.BookModel;
using Library.PersonModel;
using Library.ApplicationHelper;

namespace Library.LibraryModel
{
    internal abstract class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        protected IEnumerable<Book> GetBook( string name)
        {

            return from book in Books
                   where book.Name == name
                   select book;
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManager;
using Library.Library;
using Library.Person;

namespace Library.Book
{
    internal class Book
    {
        public Book(string name,string author,string title,int typeOfBook)
        {
            Name = name;
            Author = author;
            Title = title;
            if (Enum.IsDefined(typeof(TypeOfBookEnum), typeOfBook))
            {
                TypeOfBook = (TypeOfBookEnum)typeOfBook;
            }
            else
            {
                throw new ArgumentException("Invalid value for TypeOfBook. Must be 1 (TechnicalBook) or 2 (LiteratureBook).");
            }
        }
        public Book()
        {
            
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public TypeOfBookEnum TypeOfBook { get; set; }
    }
    public enum TypeOfBookEnum
    {
        TechnicalBook = 1,
        LiteratureBook,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManagerModel;
using Library.LibraryModel;
using Library.PersonModel;
using Library.ApplicationHelper;
using Library.Enums;

namespace Library.BookModel
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public TypeOfBookEnum TypeOfBook { get; set; }
        public Book()
        {           

        }
        public Book(string name,string author,int typeOfBook)
        {
            Name = name;
            Author = author;
            if (Enum.IsDefined(typeof(TypeOfBookEnum), typeOfBook))
            {
                TypeOfBook = (TypeOfBookEnum)typeOfBook;
            }
            else
            {
                throw new ArgumentException("Invalid value for TypeOfBook. Must be 1 (TechnicalBook) or 2 (LiteratureBook).");
            }
        }
        
    }
}

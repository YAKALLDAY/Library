using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManagerModel;
using Library.BookModel;
using Library.LibraryModel;
using Library.ApplicationHelper;

namespace Library.PersonModel
{
    internal class Person
    {
        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public PersonTypeEnum PersonType { get; set; }
        public List<Book> booksThatHeBorrowed { get; set; }
        public Person() { }
        public Person(string name,int personType)
        {
            Name = name;
            if (Enum.IsDefined(typeof(TypeOfBookEnum), personType))
            {
                PersonType = (PersonTypeEnum)personType;
            }
            else
            {
                throw new ArgumentException("Invalid value for TypeOfBook. Must be 1 (TechnicalBook) or 2 (LiteratureBook).");
            }
        }
    }
    public enum PersonTypeEnum
    {
        Student = 1,
        User
    }
}

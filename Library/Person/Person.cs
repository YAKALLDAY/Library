using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.LibraryManager;
using Library.Book;
using Library.Library;

namespace Library.Person
{
    internal class Person
    {
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
        public Person() { }
        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool HasDebt { get; set; }
        public PersonTypeEnum PersonType { get; set; }
    }
    public enum PersonTypeEnum
    {
        Student = 1,
        User
    }
}

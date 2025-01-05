using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Library.Book;
using Library.Library;
using Library.Person;

namespace Library.LibraryManager
{
    internal static class LibraryManager
    {
        public static List<Person.Person> clientOfLibrary;

        public static void BorrowBook(List<Person.Person> person, string name)
        {
            foreach (Person.Person person2 in person)
            {
                if (person2.Name == name)
                person2.HasDebt = true;
            }
        }
        public static void ReturnBook(List<Person.Person> person, string name)
        {
            foreach (Person.Person person2 in person)
            {
                if (person2.Name == name)
                    person2.HasDebt = false;
            }
        }
    }
}

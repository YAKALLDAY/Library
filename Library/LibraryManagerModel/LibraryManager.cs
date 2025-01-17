﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Library.BookModel;
using Library.LibraryModel;
using Library.PersonModel;
using Library.ApplicationHelper;
using Library.Enums;

namespace Library.LibraryManagerModel
{
    internal static class LibraryManager
    {
        public static void BorrowBook(Person person, string nameOfBook,Library.LibraryModel.Library library)
        {
            foreach(var item in library.Books)
            {
                if (item.Name == nameOfBook)
                {
                    person.booksThatHeBorrowed.Add(item);
                }
            }
        }
        public static void ReturnBook(Person person, string nameOfBook)
        {
            foreach (var item in person.booksThatHeBorrowed)
            {
                if (item.Name == nameOfBook)
                {
                    person.booksThatHeBorrowed.Remove(item);
                }
            }
        }
    }
}

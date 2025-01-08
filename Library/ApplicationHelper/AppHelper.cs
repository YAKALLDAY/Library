﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
using Library.LibraryManagerModel;
using Library.BookModel;
using Library.LibraryModel;
using Library.PersonModel;

namespace Library.ApplicationHelper
{
    internal static class AppHelper
    {
        public static void PrintListOfClientLibrary(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person.Name + "\t" + person.Id + "\t" + person.PersonType);
            }
        }
    }
}

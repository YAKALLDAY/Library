﻿using Library.LibraryManagerModel;
using Library.BookModel;
using Library.LibraryModel;
using Library.PersonModel;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Library.ApplicationHelper;
using Library.Enums;
using System.Diagnostics;


namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "Mike", PersonType = PersonTypeEnum.User });
            list.Add(new Person() { Name = "Logan", PersonType = PersonTypeEnum.Student });

            string path = "db.json";

            string json = JsonConvert.SerializeObject(list);

            File.WriteAllText(path, json);



            Library.LibraryModel.Library library = new Library.LibraryModel.Library();

            Book danBilzerianBook = new Book("The Setup", "Dan Bilzerian", 2);
            library.AddBook(danBilzerianBook);

            Book elonMuskBook = new Book("Future", "Elon Musk", 2);
            library.AddBook(elonMuskBook);

            Person person = new Person("Karen", 1);

            LibraryManager.BorrowBook(person, "Future", library);

            string jsonString = File.ReadAllText(path);

            List<Person> listOfClientLibrary = JsonConvert.DeserializeObject<List<Person>>(jsonString);

            listOfClientLibrary.Add(person);

            AppHelper.PrintListOfClientLibrary(listOfClientLibrary);

            AppHelper.PrintListOfLibraryBooks(library.Books);

            string serializeJson = JsonConvert.SerializeObject(listOfClientLibrary);
            File.WriteAllText(path, serializeJson);

            string filePathForBooks = "dbForBooks.json";
            string bookSerializeJson = JsonConvert.SerializeObject(library.Books);
            File.WriteAllText(filePathForBooks, bookSerializeJson);

            Process.Start(new ProcessStartInfo("notepad.exe", path) { UseShellExecute = true });

            //Process.Start(new ProcessStartInfo("notepad.exe", filePathForBooks) { UseShellExecute = true });

        }
    }
}

using Library.LibraryManagerModel;
using Library.BookModel;
using Library.LibraryModel;
using Library.PersonModel;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Library.ApplicationHelper;


namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> list = new List<Person>();
            //list.Add(new Person() { Name = "Mike", PersonType = PersonTypeEnum.User });
            //list.Add(new Person() { Name = "Logan", PersonType = PersonTypeEnum.Student });

            //string path = "db.json";

            //string json = JsonConvert.SerializeObject(list);

            //File.WriteAllText(path, json);



            PublicLibrary publicLibrary = new PublicLibrary();

            Book danBilzerianBook = new Book("The Setup","Dan Bilzerian",2);
            publicLibrary.Books.Add(danBilzerianBook);

            Book elonMuskBook = new Book("Future","Elon Musk",2);
            publicLibrary.Books.Add(elonMuskBook);

            Person person = new Person("Karen",1);

            LibraryManager.BorrowBook(person, "Future");



        }
    }
}

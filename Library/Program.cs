using Library.LibraryManager;
using Library.Book;
using Library.Library;
using Library.Person;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Person.Person> list = new List<Person.Person>();
            list.Add(new Person.Person() { Name = "Mike" , PersonType = PersonTypeEnum.User , HasDebt = true});
            list.Add(new Person.Person() { Name = "Logan", PersonType = PersonTypeEnum.Student, HasDebt = false });

            string path = "db.json";

            string json = JsonConvert.SerializeObject(list);

            File.WriteAllText(path, json);

        }
    }
}

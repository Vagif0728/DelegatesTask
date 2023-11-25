namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Vagif", Surname = "Garayev", Age = 19 },
                new Person { Name = "Mata", Surname = "Adigozelova", Age = 20 },
                new Person { Name = "Arif", Surname = "Garayev", Age = 15 },
                new Person { Name = "Nigar", Surname = "Qarayeva", Age = 19 },
                 new Person { Name = "Kamil", Surname = "Qarayev", Age = 21 }
            };

            List<Person> kamilInfoList = people.FindAll(p => p.Name == "Kamil");
            PrintPeople("Adi Kamil olanlar:", kamilInfoList);

            List<Person> SurnameList = people.FindAll(p => p.Surname=="ov");
            PrintPeople("Soyadi ov ve ova ile biten telebeler:", SurnameList);

            List<Person> age20List = people.FindAll(p => p.Age >= 20);
            PrintPeople("Yawi 20 den cox olanlar:", age20List);
        }

        static void PrintPeople(string message, List<Person> people)
        {
            Console.WriteLine(message);
            foreach (var person in people)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
            }
           
        }
    }
}
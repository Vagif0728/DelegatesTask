namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>
            //{
            //    new Person { Name = "Vagif", Surname = "Garayev", Age = 19 },
            //    new Person { Name = "Mata", Surname = "Adigozelova", Age = 20 },
            //    new Person { Name = "Arif", Surname = "Garayev", Age = 15 },
            //    new Person { Name = "Nigar", Surname = "Qarayeva", Age = 19 },
            //     new Person { Name = "Kamil", Surname = "Qarayev", Age = 21 }
            //};

            //List<Person> kamilInfoList = people.FindAll(p => p.Name == "Kamil");
            //PrintPeople("Adi Kamil olanlar:", kamilInfoList);

            //List<Person> SurnameList = people.FindAll(p => p.Surname=="ov");
            //PrintPeople("Soyadi ov ve ova ile biten telebeler:", SurnameList);

            //List<Person> age20List = people.FindAll(p => p.Age >= 20);
            //PrintPeople("Yawi 20 den cox olanlar:", age20List);




            List<Exam> exams= new List<Exam>
            {
                 new Exam { Subject = "Riyaziyyat", ExamDuration = 2, StartDate = DateTime.Now, EndDate = DateTime.Now },
                 new Exam { Subject = "Fizika", ExamDuration = 3, StartDate = DateTime.Now, EndDate = DateTime.Now }
            };

            List<Exam> lastWeekExams = exams.FindAll(e => (DateTime.Now - e.StartDate).TotalDays <= 7);
            PrintExams("Son 1 heftede olan imtahanlar:", lastWeekExams);

            
            List<Exam> longExams = exams.FindAll(e => e.ExamDuration > 2);
            PrintExams("2 saatdan uzun çeken imtahanlar:", longExams);

           
            List<Exam> onContionsExams = exams.FindAll(e => e.StartDate <= DateTime.Now && e.EndDate > DateTime.Now);
            PrintExams("Bawlayıb amma bitmemiw imtahanlar:", onContionsExams);
        }

        static void PrintExams(string add, List<Exam> exams)
        {
            Console.WriteLine(add);
            foreach (var exam in exams)
            {
                Console.WriteLine($"Fenn: {exam.Subject}, Muddeti: {exam.ExamDuration} saat");
            }
           
        }

        //static void PrintPeople(string message, List<Person> people)
        //{
        //    Console.WriteLine(message);
        //    foreach (var person in people)
        //    {
        //        Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Yaş: {person.Age}");
        //    }

        //}
    }
}
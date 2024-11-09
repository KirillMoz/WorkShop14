using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop14ex1
{
    internal class Program
    {
        static void PrintList(List<Contact> ListContact)
        {
            foreach (Contact Contact in ListContact)
                Console.WriteLine($"{Contact.Name} {Contact.Surname} {Contact.Phone} {Contact.Email}");            
        }
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            List<Contact> phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            Console.WriteLine("Исходный список контактов");
            PrintList(phoneBook);

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Cписок контактов отсортированный по имени (по-возрастанию)");
            var sortedContactsByName = from s in phoneBook orderby s.Name select s;
            foreach (var Contact in sortedContactsByName)
                Console.WriteLine($"{Contact.Name} {Contact.Surname} {Contact.Phone} {Contact.Email}");

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Cписок контактов отсортированный по фамилии (по-возрастанию)");
            var sortedContactsBySurname = from s in phoneBook orderby s.Surname select s;
            foreach (var Contact in sortedContactsBySurname)
                Console.WriteLine($"{Contact.Name} {Contact.Surname} {Contact.Phone} {Contact.Email}");

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Cписок контактов отсортированный по имени и фамилии (по-возрастанию)");
            var sortedContactsByNameSurname = from s in phoneBook orderby s.Name, s.Surname select s;
            foreach (var Contact in sortedContactsByNameSurname)
                Console.WriteLine($"{Contact.Name} {Contact.Surname} {Contact.Phone} {Contact.Email}");
            Console.ReadKey();
        }
    }
}

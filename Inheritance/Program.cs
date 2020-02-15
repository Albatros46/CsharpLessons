using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance //Kalıtım-Miras yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2]
            {
                new Customer{FirstName="Servet",LastName="Akçadağ"},
                new Student{FirstName="Akif",LastName="Akçadağ"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName+" "+person.LastName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departman { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] pList = new Person[3]
            {
                new Customer{FirstName = "FirstName Customer"},
                new Student{FirstName = "FirstName Student"},
                new Person{FirstName = "FirstName Person"},
            };

            foreach (var i in pList)
            {
                Console.WriteLine(i.FirstName);
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
        public string Department { get; set; }
    }
}

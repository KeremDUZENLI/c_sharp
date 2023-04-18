using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "xxx" };
            Employee employee1 = new Employee { Id = 2, FirstName = "yyy" };
            PersonDal personDal = new PersonDal();

            Person person1 = new Customer();
            Person person2 = new Employee();

            personDal.Add(customer1);
            personDal.Add(employee1);



            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNo { get; set; }
    }

    class Employee : Person
    {
        public decimal Salary { get; set; }
    }

    class PersonDal
    {
        public void Add(Person person)
        {

        }
    }
}

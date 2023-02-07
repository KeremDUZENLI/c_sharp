using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Servers();

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { 
                new SqlServer(), 
                new OracleServer(),
            };

            foreach (var i in customerDals)
            {
                i.Add();
            }

            Console.ReadLine();
        }

        static void InterfacesIntro()
        {
            PersonManager pM = new PersonManager();

            Customer c = new Customer
            {
                Id = 1,
                FirstName = "firstName Customer",
                LastName = "lastName Customer",
                Address = "address Customer",
            };
            pM.Add(c);

            Student s = new Student
            {
                Id = 2,
                FirstName = "firstName Student",
                LastName = "lastName Student",
                Department = "department Student",
            };
            pM.Add(s);
        }

        static void Servers()
        {
            CustomerManager cM = new CustomerManager();
            SqlServer sS = new SqlServer { };
            OracleServer oS = new OracleServer { };
            cM.Add(sS);
            cM.Add(oS);
        }
    }



    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirstName);
        //}

        //public void Add(Student student)
        //{
        //    Console.WriteLine(student.FirstName);
        //}

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }



    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }

    class OracleServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
    }
}

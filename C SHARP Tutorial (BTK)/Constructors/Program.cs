using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(30);
            customerManager.Add();
            customerManager.List();


            Product product1 = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            //employeeManager.Logger = new DatabaseLogger();
            employeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();


            Teacher.Number = 10;


            Utilities.Validate();


            Manager.DoSomething1();
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0}", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        //public ILogger Logger { get; set; }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation Done!");
        }
    }

    class Manager
    {
        public static void DoSomething1()
        {
            Console.WriteLine("Done 1");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}

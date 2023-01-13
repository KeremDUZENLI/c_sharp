using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "YYY", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    //[ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; } 

        [RequiredProperty]
        public string FisrtName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FisrtName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added!", customer.Id, customer.FisrtName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}

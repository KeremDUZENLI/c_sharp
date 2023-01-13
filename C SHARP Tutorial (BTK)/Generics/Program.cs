using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Kerem" }, new Customer { FirstName = "Orkut" });

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {

    }

    interface IProductDal : IRepository<Product>
    {
        new List<Product> GetAll();
        Product Get(int id);
        new void Add(Product product);
        new void Delete(Product product);
        new void Update(Product product);
    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        Product IProductDal.Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer product)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer product)
        {
            throw new NotImplementedException();
        }
    }
}

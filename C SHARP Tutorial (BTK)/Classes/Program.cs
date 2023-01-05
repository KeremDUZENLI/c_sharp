using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Kerem";
            customer1.LastName = "DUZENLI";
            customer1.City = "Ankara";


            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "A",
                LastName = "B",
                City = "C",
            };


            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.City);

            Console.ReadLine();
        }
    }
}

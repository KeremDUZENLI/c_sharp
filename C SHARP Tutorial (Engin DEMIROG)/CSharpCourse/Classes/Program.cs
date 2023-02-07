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
            CustomerManager cM = new CustomerManager();
            cM.Add();
            cM.Update();

            CustomerManager cM2 = new CustomerManager 
            {
                Id = 1,
                FirstName = "firstName",
                LastName = "lastName",
                City = "city",
            };
            Console.WriteLine(cM2.FirstName);


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

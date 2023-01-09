using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {

        static void Main(string[] args)
        {
            //ArrayList();
            //ArrayListTypeRestricted();
            //ArrayListProperties();



            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("livro", "kitap");
            dictionary.Add("mesa", "tablo");
            dictionary.Add("computador", "bilgisayar");

            Console.WriteLine(dictionary["mesa"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} / {1} - {2}", item, item.Key, item.Value);
            }

            var contain1 = dictionary.ContainsKey("livro");
            var contain2 = dictionary.ContainsValue("kalem");
            Console.WriteLine("Contain Key: {0}", contain1);
            Console.WriteLine("Contain Value: {0}", contain2);

            Console.ReadLine();
        }



        private static void ArrayList()
        {
            string[] cities1 = new string[2] { "Ankara", "İstanbul" };
            //cities1[2] = "İzmir";


            ArrayList cities2 = new ArrayList();
            cities2.Add("1");
            cities2.Add("2");

            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }
        }



        private static void ArrayListTypeRestricted()
        {
            List<string> cities3 = new List<string>();
            cities3.Add("Ankara");
            cities3.Add("İstanbul");

            foreach (var city in cities3)
            {
                Console.WriteLine(city);
            }
        }



        private static void ArrayListProperties()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Kerem" },
                new Customer { Id = 2, FirstName = "Orkut" },

            };

            var customer3 = new Customer
            {
                Id = 3,
                FirstName = "Peru",
            };

            customers.Add(customer3);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName = "XXX"},
                new Customer{Id = 5, FirstName = "YYY"},
            });

            //customers.Clear();
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);

            var contain = customers.Contains(customer3);
            Console.WriteLine("Contains: {0}", contain);

            var index = customers.IndexOf(customer3);
            Console.WriteLine("Index: {0}", index);

            customers.Insert(0, customer3);
            customers.Remove(customer3);

            foreach (var each in customers)
            {
                Console.WriteLine(each.FirstName);
            }
        }



        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
        }
    }
}

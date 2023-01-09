using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;

            Console.WriteLine(number2);



            string[] cities1 = new string[] { "Ankara", "İzmir", "Bursa" }; //101
            string[] cities2 = new string[] { "1", "2", "3" }; //102 //101

            cities2 = cities1;
            cities1[0] = "Sao Paulo";

            Console.WriteLine(cities2[0]);
 


            Console.ReadLine();
        }
    }
}

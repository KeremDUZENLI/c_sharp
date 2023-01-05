using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 20;
            if (number1 == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number1 == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }


            var number2 = 10;
            Console.WriteLine(number2 == 10 ? "Number is 10" : "Number is not 10");


            var number3 = 50;
            switch (number3)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 50:
                    Console.WriteLine("Number is 50");
                    break;
                default:
                    Console.WriteLine("Number is different");
                    break;
            }

            Console.ReadLine();
        }
    }
}

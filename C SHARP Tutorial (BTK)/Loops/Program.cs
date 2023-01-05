using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            int number = 10;
            while (number >= 0)
            {
                Console.WriteLine("Now number is {0}", number);
                number--;
            }


            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number--;
            } while (number >= 11);


            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(IsPrimeNumber(7));


            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i <= number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}

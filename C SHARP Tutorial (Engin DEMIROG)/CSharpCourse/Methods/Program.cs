using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5,10);
            Liste();
            IsPrimeNumber(199235246);


            Console.ReadLine();
        }

        static void Add(int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            Console.WriteLine(result);
        }

        static void Liste()
        {
            string[] students = new string[3] {"0", "1", "2"};

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void IsPrimeNumber(int x)
        {
            bool res = true;

            for (int i = 2; i < x; i++)
            {
                if (x%i == 0) 
                {
                    res = false;
                    break;
                } 
            }

            Console.WriteLine(res);
        }
    }
}

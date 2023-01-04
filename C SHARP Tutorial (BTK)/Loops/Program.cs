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

            Console.ReadLine();
        }
    }
}

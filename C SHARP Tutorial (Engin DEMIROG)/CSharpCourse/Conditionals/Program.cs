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
            int number = 10;

            switch (number)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 25;
            number1 = number2;
            number2 = 30;
            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 4, 5, 6 };
            numbers1 = numbers2;
            numbers2[0] = 30;
            Console.WriteLine("{0}, {1}, {2}", numbers2[0], numbers2[1], numbers2[2]);



            Console.ReadLine();
        }
    }
}

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
            Add();
            Add();
            Add();
            Add();

            var result = Add2(3, 5);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 8));

            Console.WriteLine(AddMultiple(1, 2, 3, 4, 5));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add3(int number1, int number2)
        {
            number1 = 10;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int AddMultiple(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

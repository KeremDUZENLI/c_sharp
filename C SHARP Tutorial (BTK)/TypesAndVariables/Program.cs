using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Hello World!");
            int number1 = 10;
            long number2 = 10000000000;
            short number3 = -30000;
            byte number4 = 255;
            bool condition = true;
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.5;
            decimal number6 = 10.5m;
            var number7 = 10;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number3 is {0}", number4);
            Console.WriteLine("{0}", condition);
            Console.WriteLine("{0} {1}", character, (int)character);
            Console.WriteLine("{0}", city);
            Console.WriteLine("{0}", number5);
            Console.WriteLine("{0}", number6);
            Console.WriteLine((int)Days.Sexta);
            Console.WriteLine(number7);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Segunda=10, Terça=20, Quarta, Quinta, Sexta, Sabado, Domingo
    }
}

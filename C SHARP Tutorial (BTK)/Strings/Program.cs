using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "0123 56 89";

            var result0 = sentence.Length;
            var result1 = sentence.EndsWith("9");
            var result2 = sentence.IndexOf("3");
            var result3 = sentence.Insert(10, "10");
            var result4 = sentence.Substring(8, 2);
            var result5 = sentence.Remove(3, 4);
            var result6 = sentence.Replace(" ", "*");

            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6}", result0, result1, result2, result3, result4, result5, result6);

            Console.ReadLine();
        }


        static void Intro()
        {
            string city = "Brasilia";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
        }
    }
}

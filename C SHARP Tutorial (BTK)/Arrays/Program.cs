using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];

            students[0] = "Kerem";
            students[1] = "Ali";
            students[2] = "Ayşe";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



            string[] students2 = { "1", "2", "3" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }



            string[,] regions = new string[2, 3]
            {
                { "A", "B", "C" },
                { "D", "E", "F" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }



            Console.ReadLine();
        }
    }
}

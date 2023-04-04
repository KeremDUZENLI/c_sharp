using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(DeleteEmptySpaces(word));


            Console.ReadLine();
        }

        public static string DeleteEmptySpaces(string inpt)
        {
            inpt = inpt.Trim();

            string newInpt = string.Empty;

            for (int i = 0; i < inpt.Length; i++)
            {
                if (inpt[i] == ' ')
                    continue;

                newInpt += inpt[i];
            }

            return newInpt;
        }
    }
}

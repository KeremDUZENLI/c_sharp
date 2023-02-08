using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class _Arrays
    {
        public static string FindNeedle(object[] haystack)
        {
            return string.Format("found the needle at position {0}", Array.IndexOf(haystack, "needle"));
        }

        public static int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.ToArray().Length == 0 || numbers.ToArray().Length == 1)
            {
                return 0;
            }
            else
            {
                int total = 0;
                Array.Sort(numbers);
                //Array.Reverse(numbers);

                for (var i = 1; i < (numbers.ToArray().Length)-1; i++)
                {
                    total += numbers[i];
                }

                return total;
            }
        }
    }
}

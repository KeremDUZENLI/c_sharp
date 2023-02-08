using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class _AverageSolution
    {
        public static double FindAverage(double[] array)
        {
            double total = 0;
            double n = 0;

            double len = array.ToArray().Length;

            foreach (var i in array)
            {
                total += i;
                n++;
            }

            return (len == 0) ? 0 : total / n;
        }
    }
}

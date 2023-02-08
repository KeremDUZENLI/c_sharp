using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer.Print();
            Console.ReadLine();
        }
    }

    public class Printer
    {
        public static void Print()
        {
            List<object> liste = new List<object>
            {
                _LoveDetector.lovefunc(10, 11),

                _Paper.Paperwork(10, 11),

                _AverageSolution.FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }),

                _Kata.SwitchItUp1(8),
                _Kata.SwitchItUp2(2),

                _Litre.Litres(11.5),

                _Convertion.StringToNumber("11"),
                _Convertion.StringToNumber("11,4"),

                _Arrays.FindNeedle(new object[] {"hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" }),
                _Arrays.Sum(new[] { 1,2,3,4,4 }),
            };

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }
        }
    }
}

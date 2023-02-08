using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class _Kata
    {
        public static string SwitchItUp1(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "zero";
            }
        }

        public static string SwitchItUp2(int number)
        {
            var dic = new Dictionary<int, string>()
            {
                  {1, "One"},
                  {2, "Two"},
                  {3, "Three"},
                  {4, "Four"},
                  {5, "Five"},
                  {6, "Six"},
                  {7, "Seven"},
                  {8, "Eight"},
                  {9, "Nine"},
                  {0, "Zero"},
            };

            return dic[number];
        }
    }
}

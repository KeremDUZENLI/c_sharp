using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] { "xx", "yy", "zz" };
            string[] sehirler2 = new string[] { "tt", "ll", "mm" };

            sehirler1 = sehirler2;

            sehirler1[0] = "pp";

            for(int i = 0; i < sehirler1.Length; i++) {
                Console.WriteLine("sehirler1: {0}", sehirler1[i]);
                Console.WriteLine("sehirler2: {0}", sehirler2[i]);
            }



            Console.ReadLine();
        }
    }
}

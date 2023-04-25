using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    static class ClassStatic
    {
        public static void Say(string name)
        {
            Console.WriteLine("static " + name);
        }
    }
}

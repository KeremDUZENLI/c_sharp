using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class _LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 != 0;
        }
    }
}

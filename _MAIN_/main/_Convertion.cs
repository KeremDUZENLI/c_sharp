using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class _Convertion
    {
        public static int StringToNumber(String str)
        {
            //return int.Parse(str);

            if (int.TryParse(str, out int number))
            {
                return int.Parse(str);
            }
            else if (double.TryParse(str, out double numberDec))
            {
                return (int)double.Parse(str);
            }
            else
            {
                return 0;
            }
        }
    }
}

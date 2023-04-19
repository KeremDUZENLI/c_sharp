using Business.Abstract;
using Business.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingConventions
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonService customerService = NinjectInstanceFactory.GetInstance<IPersonService>();

            customerService.Add(new Customer());
        }
    }
}

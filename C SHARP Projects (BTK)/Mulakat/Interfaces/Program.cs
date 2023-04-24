using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IMevzuat>().To<BirinciMevzuat>().InSingletonScope();

            CustomerManager customerManager = new CustomerManager(kernel.Get<IMevzuat>());
            customerManager.Add();



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private IMevzuat _mevzuat;

        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }

        public void Add()
        {
            _mevzuat.IslemYap();
        }
    }

    interface IMevzuat
    {
        void IslemYap();
    }

    class BirinciMevzuat : IMevzuat
    {
        public void IslemYap()
        {
            Console.WriteLine("Birinci Mevzuat");
        }
    }

    class İkinciMevzuat : IMevzuat
    {
        public void IslemYap()
        {
            Console.WriteLine("İkinci Mevzuat");
        }
    }
}

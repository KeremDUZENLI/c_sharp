using Business;
using Business.Abstract;
using Business.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeDemo();
            IProductService personService = NinjectInstanceFactory.GetInstance<IProductService>();
            var result = personService.GetAll();

            foreach (var product in result)
            {
                Console.WriteLine(product.Name);
            }


            Console.ReadLine();
        }

        private static void EmployeeDemo()
        {
            IEmployeeService employeeService = NinjectInstanceFactory.GetInstance<IEmployeeService>();
            var result = employeeService.GetAll();

            foreach (var employee in result)
            {
                Console.WriteLine(employee.FirstName);
            }
        }
    }
}

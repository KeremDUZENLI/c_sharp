using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        private int Id1 { get; set; }
        protected int Id2 { get; set; }

        public void Save()
        {

        }

        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
        }
    }

    public class Course
    {
        public string Name { get; set; }
    }
}

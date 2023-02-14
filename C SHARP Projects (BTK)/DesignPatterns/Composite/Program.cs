using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Name = "1" };
            Employee employee2 = new Employee { Name = "2" };
            Employee employee3 = new Employee { Name = "3" };
            Employee employee4 = new Employee { Name = "4" };
            Contractor employee5 = new Contractor { Name = "5" };

            employee1.AddSubordinate(employee2);
            employee1.AddSubordinate(employee3);
            employee3.AddSubordinate(employee4);
            employee3.AddSubordinate(employee5);

            Console.WriteLine("1");
            foreach (Employee manager in employee1)
            {
                Console.WriteLine("  {0}", manager.Name);

                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    {0}", employee.Name);
                }
            }


            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set;}

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var item in _subordinates)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

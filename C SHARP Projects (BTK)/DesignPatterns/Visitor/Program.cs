using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager { Name = "Kerem", Salary = 2000 };
            Manager m2 = new Manager { Name = "Adam", Salary = 12000 };

            Worker w1 = new Worker { Name = "xxx", Salary = 1500 };
            Worker w2 = new Worker { Name = "yyy", Salary = 3200 };

            m1.Subordinates.Add(m2);
            m2.Subordinates.Add(w1);
            m2.Subordinates.Add(w2);

            OrganisationalStructure oS = new OrganisationalStructure(m1);

            PayrollVisitor pV = new PayrollVisitor();
            PayRaise pR = new PayRaise();

            oS.Accept(pV);
            oS.Accept(pR);



            Console.ReadLine();
        }
    }

    class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }

    abstract class EmployeeBase
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public abstract void Accept(VisitorBase vB);
    }

    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public List<EmployeeBase> Subordinates { get; set; }

        public override void Accept(VisitorBase vB)
        {
            vB.Visit(this);

            foreach (var i in Subordinates)
            {
                i.Accept(vB);
            }
        }
    }

    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase vB)
        {
            vB.Visit(this);
        }
    }


    abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }

    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }
    }

    class PayRaise : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary * (decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}", manager.Name, manager.Salary * (decimal)1.2);
        }
    }
}

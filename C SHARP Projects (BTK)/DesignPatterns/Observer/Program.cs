using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pM = new ProductManager();

            var customerObserver = new CustomerObserver();
            pM.Attach(customerObserver);
            pM.Detach(customerObserver);

            pM.Attach(new EmployeeObserver());


            pM.UpdatePrice();


            Console.ReadLine();
        }
    }

    class ProductManager
    {
        List<Observer> observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var i in observers)
            {
                i.Update();
            }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Product price changed");
        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Product price changed");
        }
    }
}

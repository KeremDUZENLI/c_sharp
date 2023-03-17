using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManager sM = new StockManager();

            BuyStock bS = new BuyStock(sM);
            SellStock sS = new SellStock(sM);

            StockController sC = new StockController();

            sC.TakeOrder(bS);
            sC.TakeOrder(sS);
            sC.TakeOrder(bS);

            sC.PlaceOrders();



            Console.ReadLine();
        }
    }

    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock: {0}, {1} bought!", _name, _quantity);
        }

        public void Sell()
        {
            Console.WriteLine("Stock: {0}, {1} sold!", _name, _quantity);
        }
    }

    interface IOrder
    {
        void Execute();
    }

    class BuyStock : IOrder
    {
        private StockManager _stockManager;
        public BuyStock(StockManager sM)
        {
            _stockManager = sM;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }

    class SellStock : IOrder
    {
        private StockManager _stockManager;
        public SellStock(StockManager sM)
        {
            _stockManager = sM;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }

    class StockController
    {
        List<IOrder> _orders = new List<IOrder>();

        public void TakeOrder(IOrder o)
        {
            _orders.Add(o);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}

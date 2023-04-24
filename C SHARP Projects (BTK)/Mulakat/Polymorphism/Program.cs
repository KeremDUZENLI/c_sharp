using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //IShape sekil = new Triangle();
            DrawManager manager = new DrawManager(new Rectangle());
        }
    }

    interface IShape
    {
        void Draw();
    }

    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Dirtdörtgen çizildi");
        }
    }

    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Üçgen çizildi");
        }
    }

    class DrawManager
    {
        private IShape _shape;
        public DrawManager(IShape shape)
        {
            shape = _shape;
        }

        public void Draw()
        {
            _shape.Draw();
        }
    }
}

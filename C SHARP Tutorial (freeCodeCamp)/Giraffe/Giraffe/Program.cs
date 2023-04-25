using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBook();
            ClassStatic.Say("xxx");

            Console.ReadLine();
        }

        private static void GetBook()
        {
            Book book1 = new Book("HP", "J.K. Rowling", 700, "low");
            Book book2 = new Book("LoR", "Talkien", 800, "xxx");

            Console.WriteLine(book1._author);
            Console.WriteLine(book2._title);

            Console.WriteLine(book1.ReadLong());
            Console.WriteLine(book2.ReadLong());

            Console.WriteLine(book1.Rating);
            Console.WriteLine(book2.Rating);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member { Email = "xxxyyy@gmail.com", FirstName = "xxx", LastName = "yyy", DateOfBirth = new DateTime(1990, 1, 1), TcNo = "12345678900" });
            Console.WriteLine("Done");


            Console.ReadLine();
        }
    }
}

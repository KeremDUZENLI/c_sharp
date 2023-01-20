using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelamVer("XXX");
            //Topla(2, 3);

            //List<string> sehirler = new List<string> { "A", "B", "C" };
            //sehirler.Add("D");

            //for(int i = 0; i < sehirler.ToArray().Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}

            Person person1 = new Person();
            person1.FirstName = "AAA";
            person1.LastName = "BBB";
            person1.DateOfBirthYear = 1900;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim = "")
        {
            Console.WriteLine(isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }

    }

}

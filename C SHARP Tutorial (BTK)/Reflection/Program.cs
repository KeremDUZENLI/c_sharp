﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine("Topla2: {0}", dortIslem.Topla2());

            //Console.WriteLine("Topla1: {0}", dortIslem.Topla1(3, 4));



            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7);
            //Console.WriteLine(dortIslem.Topla1(4, 5));
            //Console.WriteLine(dortIslem.Topla2());



            var instance = Activator.CreateInstance(tip, 6, 7);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));



            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı: {0}", info.Name);

                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
                }
            }



            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla1(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp1(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma Islemi 2")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }



    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }

}

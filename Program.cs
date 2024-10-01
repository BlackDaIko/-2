using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пркатика 3.2.2.");
            Console.WriteLine("Привет, \nМир!");


            Console.WriteLine();
            Console.WriteLine("Практика 3.2.8");
            const string MyName = "DaIko";
            Console.WriteLine("\tПривет, мир!");
            Console.WriteLine("\t Мне 18 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            Console.WriteLine();
            Console.WriteLine("Практика 3.3.2");
            string MyName2 = "DaIKO";
            byte MyAge = 18;
            bool HaveIApet = false;
            double MyShoeSize = 45;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAS;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine(double.TryParse("15",out r));
            Console.WriteLine("HI");
            Console.ReadKey();
        }
    }
}

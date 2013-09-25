using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAS;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Element> e = Parser.Parse("2x +  3");

            foreach (Element ele in e)
            {
                Console.WriteLine(ele);
            }
            Console.ReadKey();
        }
    }
}

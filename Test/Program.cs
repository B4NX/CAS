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
            Equation fx=new Equation(Parser.Parse("2x +  3"));

            //foreach (Element ele in fx)
            //{
            //    Console.WriteLine(ele);
            //}
        }

        private static long Factorial_Func(long n)
        {
            if (n == 0 || n == 1) { return 1; }

            //long tempN = n;
            //long holder = n;

            long output=1;

            for (long x = 1; x <= n; x++)
            {
                output *= x;
            }
            return output;
        }
    }
}

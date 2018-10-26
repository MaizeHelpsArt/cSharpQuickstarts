using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithTheDoubleType
{
    class Program
    {
        static void Main(string[] args)
        {
            // double has more precision division has decimals

            //double a = 5;
            //double b = 4;
            //double c = 2;
            //double d = (a + b) / c;

            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}.");

            // V .3 repeating is not the same as 1/3

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            Console.WriteLine(d);
        }
    }
}

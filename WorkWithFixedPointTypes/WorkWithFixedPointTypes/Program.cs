using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFixedPointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal type, smaller range but higher percision than double

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            // compare and contrast

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);

            double r = 2.50;
            double area = (Math.PI * (r * r));
            Console.WriteLine(area);


        }
    }
}

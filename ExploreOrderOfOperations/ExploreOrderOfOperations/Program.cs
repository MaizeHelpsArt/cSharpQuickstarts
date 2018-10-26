using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOrderOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // order of operations are the same same
            //int a = 5;
            //int b = 4;
            //int c = 2;
            //int d = a + b * c;

            //int a = 5;
            //int b = 4;
            //int c = 2;
            //int d = (a + b) * c;

            //int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;

            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;


            Console.WriteLine(d);
        }
    }
}

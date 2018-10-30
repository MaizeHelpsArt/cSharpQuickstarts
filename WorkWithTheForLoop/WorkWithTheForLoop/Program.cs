using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithTheForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop, 3 parts (initializer, condition, iterator)
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
        }
    }
}

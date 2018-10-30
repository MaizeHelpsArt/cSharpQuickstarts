using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseLoopsToRepeatOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // do while
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter2 is {counter2}");
                counter2++;
            } while (counter2 < 10);


        }
    }
}

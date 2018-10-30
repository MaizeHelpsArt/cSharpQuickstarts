using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAnInterpolatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            // interpolated string, consists of $ and {}
            var name = "Jacob";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }
    }
}

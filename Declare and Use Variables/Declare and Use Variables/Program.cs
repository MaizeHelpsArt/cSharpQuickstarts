using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareAndUseVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            // string interpolation

            Console.WriteLine($"Hello {aFriend}");
        }
    }
}

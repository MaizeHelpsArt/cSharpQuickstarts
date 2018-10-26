using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // contains, will display T/F

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // startswith and endswith

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
        }
    }
}

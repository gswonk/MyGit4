using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class t4App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world...");
            Console.WriteLine("The rains in Spain fall mainly on the plains...");
            Console.WriteLine("The quick brown fox jumps over the lazy dog...");

            for (var i=0; i<10; i++)
            {
                Console.WriteLine($"{i}.Hello, world...");
            }
        }
    }
}

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

            for (var i=0; i<30; i++)
            {
                Console.WriteLine($"{i}.Hello, world...");
            }
        }
    }
}

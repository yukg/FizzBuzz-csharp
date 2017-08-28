using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzzLib();
            Console.WriteLine(fb.Generate(16));

            Console.ReadLine();
        }
    }
}

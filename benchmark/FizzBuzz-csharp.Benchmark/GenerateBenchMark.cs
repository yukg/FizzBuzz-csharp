using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_csharp.Benchmark
{
    public class GenerateBenchMark
    {
        //[Params(1, 10, 100, 1000)]
        [Params(1000)]
        public int Val { get; set; }

        [Benchmark]
        public string FizzBuzzLib_Generate()
        {
            var fb = new FizzBuzzLib();
            return fb.Generate(Val);
        }

        [Benchmark]
        public string FizzBuzzLib2_Generate()
        {
            var fb = new FizzBuzzLib2();
            return fb.Generate(Val);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_csharp
{
    public class FizzBuzzLib2
    {
        public string Generate(int count)
        {
            if (count < 1) { throw new ArgumentOutOfRangeException(nameof(count), count, "Please enter a value greater than or equal to 1."); }

            var resultList = Enumerable
                .Range(1, count)
                .Select(v => ConvertToFizzBuzz(v));

            return string.Join(" ", resultList);
        }

        public string ConvertToFizzBuzz(int val)
        {
            if (val < 1) { throw new ArgumentOutOfRangeException(nameof(val), val, "Please enter a value greater than or equal to 1."); }

            string ret = string.Empty;
            if (val % 3 == 0) { ret += "Fizz"; }
            if (val % 5 == 0) { ret += "Buzz"; }
            if (ret == string.Empty) { ret = val.ToString(); }
            return ret;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz_csharp.Test
{
    public class FizzBuzzLibTest
    {
        [Theory(DisplayName = "Normal Test")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(2147483640, "FizzBuzz")]
        [InlineData(2147483645, "Buzz")]
        [InlineData(2147483646, "Fizz")]
        [InlineData(int.MaxValue, "2147483647")]
        public void ConvertToFizzBuzzTest_Normal(int val, string expected)
        {
            var fb = new FizzBuzzLib();
            Assert.Equal(expected, fb.ConvertToFizzBuzz(val));
        }

        [Theory(DisplayName = "Abnormal Test")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue + 1)]
        [InlineData(int.MinValue)]
        public void ConvertToFizzBuzzTest_Abnromal(int val)
        {
            var fb = new FizzBuzzLib();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                fb.ConvertToFizzBuzz(val);
            });
        }

        [Theory(DisplayName = "Abnormal Test")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue + 1)]
        [InlineData(int.MinValue)]
        public void GenerateTest_Abnormal(int val)
        {
            var fb = new FizzBuzzLib();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                fb.Generate(val);
            });
        }

        [Theory(DisplayName = "Normal Test")]
        [ClassData(typeof(GenerateTestDataClass))]
        public void GenerateTest_Normal(int val, string expected)
        {
            var fb = new FizzBuzzLib();
            Assert.Equal(expected, fb.Generate(val));
        }

        class GenerateTestDataClass : IEnumerable<object[]>
        {
            List<object[]> _testData = new List<object[]>();

            public GenerateTestDataClass()
            {
                _testData.Add(new object[] { 16, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16" });
                _testData.Add(new object[] { 4, "1 2 Fizz 4" });
            }

            public IEnumerator<object[]> GetEnumerator() => _testData.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}

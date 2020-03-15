using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class AddBinaryTest
    {
        [Theory]
        [InlineData("1", "2", "3")]
        public void TestMethod(string a, string b, string output)
        {
            Assert.Equal(output, Solution067.AddBinary(a, b));
        }
    }
}


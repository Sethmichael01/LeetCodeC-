using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class UniquePathsTest
    {
        [Theory]
        [InlineData(3,7,28)]
        public void TestMethod(int m, int n, int output)
        {
            Assert.Equal(output, Solution062.UniquePaths(m, n));
        }
    }
}


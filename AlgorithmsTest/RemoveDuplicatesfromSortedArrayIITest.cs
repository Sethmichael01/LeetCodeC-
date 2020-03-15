using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveDuplicatesfromSortedArrayIITest
    {
        [Theory]
        [InlineData(new[]{1,2}, 0)]
        public void TestMethod(int[] nums, int output)
        {
            Assert.Equal(output, Solution080.RemoveDuplicates(nums));
        }
    }
}


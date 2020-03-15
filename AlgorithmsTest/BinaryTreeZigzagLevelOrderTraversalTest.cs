using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class BinaryTreeZigzagLevelOrderTraversalTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(TreeNode root, IList<IList<int>> output)
        {
            Assert.Equal(output, Solution103.ZigzagLevelOrder(root));
        }
    }
}


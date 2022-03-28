using DotPrep.DSA.Heap;
using Xunit;

namespace DotPrep.DSATest.Heap
{
    public class SmallestElementTest
    {
        SmallestElement _smallestElement;

        public SmallestElementTest()
        {
            _smallestElement = new SmallestElement();
        }

        [Fact]
        public void Test1()
        {
            var expected = 13;
            var mat = new int[][]
            {
                new int[] {1, 5, 9},
                new int[] {10, 11, 13},
                new int[] {12, 13, 15},
            };
            var actual = _smallestElement.KthSmallest(mat, 8);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var expected = -5;
            var mat = new int[][]
            {
                new int[] {-5},
            };
            var actual = _smallestElement.KthSmallest(mat, 1);
            Assert.Equal(expected, actual);
        }
    }
}

using DotPrep.DSA.Heap;
using Xunit;

namespace DotPrep.DSATest.Heap
{
    public class LargestElementTest
    {
        LargestElement _largestElement;

        public LargestElementTest()
        {
            _largestElement = new LargestElement();
        }

        [Fact]
        public void Test1()
        {
            var expected = 5;
            var nums = new int[] { 3, 2, 1, 5, 6, 4 };
            var actual = _largestElement.FindKthLargest(nums, 2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var expected = 4;
            var nums = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var actual = _largestElement.FindKthLargest(nums, 4);
            Assert.Equal(expected, actual);
        }
    }
}

using DotPrep.DSA.BinarySearch;
using Xunit;

namespace DotPrep.DSATest.BinarySearch
{
    public class SplitArrayLargestSumTest
    {
        SplitArrayLargestSum _splitArrayLargestSum;
        public SplitArrayLargestSumTest()
        {
            _splitArrayLargestSum = new SplitArrayLargestSum(); 
        }
        [Fact]
        void Test1()
        {
            var arr = new int[] { 7, 2, 5, 10, 8 };
            var count = 2;
            var actual = _splitArrayLargestSum.FindMinimizedMaximumSum(arr, count);
            var expected = 18;
            Assert.Equal(expected, actual);
        }
        [Fact]
        void Test2()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };
            var count = 2;
            var actual = _splitArrayLargestSum.FindMinimizedMaximumSum(arr, count);
            var expected = 9;
            Assert.Equal(expected, actual);
        }
        [Fact]
        void Test3()
        {
            var arr = new int[] { 1, 4, 4 };
            var count = 3;
            var actual = _splitArrayLargestSum.FindMinimizedMaximumSum(arr, count);
            var expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}

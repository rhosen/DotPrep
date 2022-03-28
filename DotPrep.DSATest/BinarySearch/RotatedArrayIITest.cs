using DotPrep.DSA.BinarySearch;
using Xunit;

namespace DotPrep.DSATest.BinarySearch
{
    public class RotatedArrayIITest
    {
        RotatedArrayII _rotatedArrayII;

        public RotatedArrayIITest()
        {
            _rotatedArrayII = new RotatedArrayII();
        }

        [Fact]
        void Test1()
        {
            var nums = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            var target = 0;
            var expected = true;
            var actual = _rotatedArrayII.Search(nums, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test2()
        {
            var nums = new int[] { 2, 5, 6, 0, 0, 1, 2 };
            var target = 3;
            var expected = false;
            var actual = _rotatedArrayII.Search(nums, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test3()
        {
            var nums = new int[] { 0, 1, 1, 2, 0, 0 };
            var target = 2;
            var expected = true;
            var actual = _rotatedArrayII.Search(nums, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test4()
        {
            var nums = new int[] { 1, 0, 1, 1, 1 };
            var target = 0;
            var expected = true;
            var actual = _rotatedArrayII.Search(nums, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test5()
        {
            var nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1 };
            var target = 2;
            var expected = true;
            var actual = _rotatedArrayII.Search(nums, target);
            Assert.Equal(expected, actual);
        }
    }
}

using DotPrep.DSA.CycleSort;
using Xunit;

namespace DotPrep.DSATest.CycleSort
{
    public class FindDuplicateTest
    {
        FindDuplicate _findDuplicate;

        public FindDuplicateTest()
        {
            _findDuplicate = new FindDuplicate();
        }

        [Fact]
        void Test1()
        {
            var nums = new int[] { 1, 3, 4, 2, 2 };
            var expected = 2;
            var actual = _findDuplicate.FindDuplicateElement(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test2()
        {
            var nums = new int[] { 3, 1, 3, 4, 2 };
            var expected = 3;
            var actual = _findDuplicate.FindDuplicateElement(nums);
            Assert.Equal(expected, actual);
        }
    }
}

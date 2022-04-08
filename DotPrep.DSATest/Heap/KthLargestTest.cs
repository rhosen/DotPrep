using DotPrep.DSA.Heap;
using System.Collections.Generic;
using Xunit;

namespace DotPrep.DSATest.Heap
{
    public class KthLargestTest
    {

        KthLargest _kthLargest;

        public KthLargestTest()
        {
            var k = 3;
            var arr = new int[] { 4, 5, 8, 2 };
            _kthLargest = new KthLargest(k, arr);

        }

        [Fact]
        public void Test1()
        {
            var expected = new List<int> { 4, 5, 5, 8, 8 };
            var actual = new List<int> { };
            actual.Add(_kthLargest.Add(3));
            actual.Add(_kthLargest.Add(5));
            actual.Add(_kthLargest.Add(10));
            actual.Add(_kthLargest.Add(9));
            actual.Add(_kthLargest.Add(4));

            Assert.Equal(expected, actual);
        }
    }
}

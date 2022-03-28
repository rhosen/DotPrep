using DotPrep.DSA.Heap;
using Xunit;

namespace DotPrep.DSATest.Heap
{
    public class WeakestRowTest
    {
        WeakestRow _weakestRow;

        public WeakestRowTest()
        {
            _weakestRow = new WeakestRow();
        }

        [Fact]
        public void Test1()
        {
            var expected = new int[] { 2, 0, 3 };
            var arr = new int[][]
            {
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0},
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 1},
            };
            var actual = _weakestRow.KWeakestRows(arr, 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var expected = new int[] { 0, 2 };
            var arr = new int[][]
            {
                new int[] {1, 0, 0, 0},
                new int[] {1, 1, 1, 1},
                new int[] {1, 0, 0, 0},
                new int[] {1, 0, 0, 0},
            };
            var actual = _weakestRow.KWeakestRows(arr, 2);
            Assert.Equal(expected, actual);
        }
    }
}
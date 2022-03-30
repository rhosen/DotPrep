using DotPrep.DSA.Matrix;
using Xunit;

namespace DotPrep.DSATest.Matrix
{
    public class Search2DMatrixTest
    {

        Search2DMatrix _search2DMatrix;

        public Search2DMatrixTest()
        {
            _search2DMatrix = new Search2DMatrix();
        }

        [Fact]
        void Test1()
        {
            var mat = new int[][]
            {
                new int[] {1,3,5,7},
                new int[] {10,11,16,20},
                new int[] {23,30,34,60},
            };
            var target = 3;
            var expected = true;
            var actual = _search2DMatrix.SearchMatrix(mat, target);
            Assert.Equal(expected, actual);
        }

        [Fact]
        void Test2()
        {
            var mat = new int[][]
            {
                new int[] {1,3,5,7},
                new int[] {10,11,16,20},
                new int[] {23,30,34,60},
            };
            var target = 13;
            var expected = false;
            var actual = _search2DMatrix.SearchMatrix(mat, target);
            Assert.Equal(expected, actual);
        }
    }
}

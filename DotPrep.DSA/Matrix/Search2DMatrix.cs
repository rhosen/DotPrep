namespace DotPrep.DSA.Matrix
{
    // https://leetcode.com/problems/search-a-2d-matrix/

    public class Search2DMatrix
    {
        // since all the rows of the matrix are sorted
        // it's very tempting to use a binary search on each row to find the target
        // but if we pay attention we will see that columns are also sorted
        // and we can use this unique property to reduce the search complexity to O(n)
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = 0;
            // we will start from the last index of the first row
            var col = matrix[row].Length - 1;
            // and continue searching till the first index of each row
            while (row < matrix.Length && col >= 0)
            {
                if (matrix[row][col] == target) return true;
                // if the current value is smaller than the target value then it is not present on the current row
                // so we need to check the next rows
                else if (matrix[row][col] < target) row++;
                // if the current value is greater than target value then it is not present on current column
                // so we need to check previous columns
                else col--;
            }
            return false;
        }
    }
}

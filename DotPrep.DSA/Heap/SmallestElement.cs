namespace DotPrep.DSA.Heap
{
    // https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/

    public class SmallestElement
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var maxHeap = new PriorityQueue<int, int>(new ElementComparer());

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    maxHeap.Enqueue(matrix[i][j], matrix[i][j]);
                    if (maxHeap.Count > k) maxHeap.Dequeue();
                }
            }
            var result = maxHeap.Dequeue();
            return result;
        }
    }

    class ElementComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}

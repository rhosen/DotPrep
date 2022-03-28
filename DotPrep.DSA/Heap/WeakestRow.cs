namespace DotPrep.DSA.Heap
{
    // https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/

    class Pair : IComparable<Pair>
    {
        public int Index { get; set; }
        public int Value { get; set; }

        public int CompareTo(Pair? p)
        {
            // if two rows has equal number of soldiers then one with the greater index is strongest
            if (this.Value == p.Value) return p.Index - this.Index;
            // else rows with the most soldiers is strongest
            else return p.Value - this.Value;
        }
    }

    public class WeakestRow
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            var matSum = CountSoldiersByRow(mat);

            var maxHeap = new PriorityQueue<int, Pair>();
            for (int i = 0; i < matSum.Length; i++)
            {
                var pair = new Pair() { Index = i, Value = matSum[i] };
                maxHeap.Enqueue(i, pair);
                // we only need to find k weakest row so we remove n-k strongest rows
                // where n is total number of rows
                if (maxHeap.Count > k) maxHeap.Dequeue();
            }

            int[] result = FillResult(maxHeap);
            return result;
        }

        private int[] FillResult(PriorityQueue<int, Pair> maxHeap)
        {
            var result = new int[maxHeap.Count];
            // since we created max heap, strongest rows will be on top
            // so we fill the array from last index
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = maxHeap.Dequeue();
            }

            return result;
        }

        private int[] CountSoldiersByRow(int[][] mat)
        {
            var sum = new int[mat.Length];
            for (int row = 0; row < mat.Length; row++)
            {
                sum[row] += mat[row].Sum();
            }
            return sum;
        }
    }
}

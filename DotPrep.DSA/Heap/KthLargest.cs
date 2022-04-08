namespace DotPrep.DSA.Heap
{
    // https://leetcode.com/problems/kth-largest-element-in-a-stream/
    public class KthLargest
    {

        PriorityQueue<int, int> minHeap;
        int count;

        public KthLargest(int k, int[] nums)
        {
            minHeap = new PriorityQueue<int, int>();
            count = k;
            foreach (var num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            minHeap.Enqueue(val, val);
            if (minHeap.Count > count) minHeap.Dequeue();
            return minHeap.Peek();
        }
    }
}

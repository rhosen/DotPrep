namespace DotPrep.DSA.Heap
{
    // https://leetcode.com/problems/kth-largest-element-in-an-array/

    public class LargestElement
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var minHeap = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Enqueue(nums[i], nums[i]);
                if (minHeap.Count > k) minHeap.Dequeue();
            }
            var result = minHeap.Dequeue();
            return result;
        }
    }
}

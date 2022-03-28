using System.Text;

namespace DotPrep.DSA.Heap
{
    // https://leetcode.com/problems/sort-characters-by-frequency/

    public class FrequencySort
    {
        public string SortCharactersByFrequency(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (var c in s)
            {
                map[c] = map.GetValueOrDefault(c, 0) + 1;
            }
            var maxHeap = new PriorityQueue<KeyValuePair<char, int>, int>(new FrequencyComparer());
            foreach (var item in map)
            {
                maxHeap.Enqueue(new KeyValuePair<char, int>(item.Key, item.Value), item.Value);
            }
            var sb = new StringBuilder();
            while (maxHeap.Count > 0)
            {
                var item = maxHeap.Dequeue();
                var str = new string(item.Key, item.Value);
                sb.Append(str);
            }
            return sb.ToString();
        }
    }

    class FrequencyComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}

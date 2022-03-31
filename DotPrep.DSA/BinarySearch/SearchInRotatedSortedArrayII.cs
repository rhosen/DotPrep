namespace DotPrep.DSA.BinarySearch
{

    // https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    // https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/

    public class SearchInRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {
            var n = nums.Length;
            // if nums not rotated then apply simple binary search
            if (nums.Length == 1 || nums[0] < nums[n - 1])
                return Search(nums, 0, n - 1, target);

            var index = FindFirstOccuranceOfMinimumElement(nums);
            if (nums[index] == target) return true;

            // search on left side
            if (Search(nums, 0, index - 1, target)) return true;
            // search on the right side
            else return Search(nums, index, n - 1, target);
        }

        int FindFirstOccuranceOfMinimumElement(int[] nums)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start < end)
            {
                var mid = start + (end - start) / 2;
                // if middle element is greater than last element than min element will be found at right side
                if (nums[mid] > nums[end]) start = mid + 1;
                else if (nums[mid] == nums[end])
                {
                    // mid and end element could be same
                    // but there could be a larger element between them
                    if (end > start && nums[end - 1] > nums[end]) return end;
                    // this might be the minimum number but it's not the first occurance
                    // so we keep looking for first minimum occurance
                    end--;
                }
                // the element at mid is the minimum number untill now
                // there could be more minimum number(s) on the left side but we don't know for sure
                // that's why we can't risk to do mid-1
                else end = mid;
            }
            return start;
        }

        bool Search(int[] nums, int start, int end, int target)
        {
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (nums[mid] == target) return true;
                else if (nums[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
            return false;
        }
    }
}

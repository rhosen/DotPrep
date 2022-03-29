namespace DotPrep.DSA.CycleSort
{
    // https://leetcode.com/problems/find-the-duplicate-number/

    public class FindDuplicate
    {
        public int FindDuplicateElement(int[] nums)
        {
            // if we can sort the elements then we can find the duplicate element easily
            // but we know that sorting takes O(n log n) time
            // since there are only 1 to n elements so we can use cycle sort
            CycleSort(nums);
            // now, every element should be at its corresponding index except the duplicate element
            return Find(nums);
        }

        // 1. if sorted then 1 should be at 0th index, 2 should be at 1st index, so on and so forth
        // 2. so we will check if the elements are placed at the correct index or not
        // 3. if placed rightly then we will not do anything
        // 4. otherwise we will swap it with the element at the correct index
        // 5. and we will repeat steps 2 to 4 for the newly swapped element
        void CycleSort(int[] nums)
        {
            var i = 0;
            while (i < nums.Length)
            {
                var correctIndex = nums[i] - 1;
                if (nums[correctIndex] == nums[i]) i++;
                else (nums[i], nums[correctIndex]) = (nums[correctIndex], nums[i]);
            }
        }

        int Find(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) return nums[i];
            }
            return -1;
        }
    }
}
namespace DotPrep.DSA.BinarySearch
{
    public class SplitArrayLargestSum
    {
        // We don't know what can be the minimized maximum sum
        // However, we know that the largest element in the array can be the lowest maximum if we split the array into n part where n = array.Length
        // Again, if we split the array into 1 part, the maximum sum will be the sum of all the element in the array
        // Now, we have a range and applying binary search in this range we can find the number that fulfills given conditions
        public int FindMinimizedMaximumSum(int[] array, int count)
        {
            var range = GetRange(array);
            var start = range.start;
            var end = range.end;
            int maxSum = 0;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                var currentCount = GetSplitCount(array, count, mid);
                // the array got splited into more pieces than we wanted
                // so we need a bigger sum
                // to get bigger sum we need to increase the range
                // we can do that either by increasing the end or the start
                // however we can't increase the end because it can not be bigger than arraySum
                // so we will increate start to get a bigger sum
                if (currentCount > count) start = mid + 1;
                else
                {
                    // got our sum
                    maxSum = mid;
                    // but let's see if we can minimize it even further
                    end = mid - 1; 
                }
            }
            return maxSum; // or start
        }

        int GetSplitCount(int[] array, int count, int allowedSum)
        {
            int sum = 0;
            // we haven't splitted the array till now
            // or we can say we splitted it one time only
            var currentCount = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum > allowedSum)
                {
                    // after adding the new element our sum got bigger than allowed
                    // that means we need to split the array at i-1th index and start a new array from ith position
                    sum = array[i];
                    // we increase the counter to indicate that we have splited the array 1 time
                    currentCount++; 
                }
                if (currentCount > count) return currentCount;
            }
            return currentCount;
        }

        (int start, int end) GetRange(int[] array)
        {
            int max = 0, arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                arraySum += array[i];
            }
            return (max, arraySum);
        }
    }
}

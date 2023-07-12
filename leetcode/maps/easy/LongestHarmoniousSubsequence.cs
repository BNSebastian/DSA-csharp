#region Description

/*
We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.

Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.

A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.

Example 1:

Input: nums = [1,3,2,2,5,2,3,7]
Output: 5
Explanation: The longest harmonious subsequence is [3,2,2,2,3].

Example 2:

Input: nums = [1,2,3,4]
Output: 2

Example 3:

Input: nums = [1,1,1,1]
Output: 0
*/

#endregion

namespace leetcode.maps.easy
{
    public static class LongestHarmoniousSubsequence
    {
        public static int Solution(int[] nums)
        {
            Array.Sort(nums);
            var map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num)) map[num]++;
                else map[num] = 1;
            }

            int max = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] == 1)
                {
                    max = Math.Max(max, map[nums[i + 1]] + map[nums[i]]);
                }
            }

            return max;
        }
    }
}
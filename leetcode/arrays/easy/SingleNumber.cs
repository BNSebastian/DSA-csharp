#region Description

/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

Example 1:

Input: nums = [2,2,1]
Output: 1

Example 2:

Input: nums = [4,1,2,1,2]
Output: 4

Example 3:

Input: nums = [1]
Output: 1
*/

#endregion

namespace leetcode.arrays.easy
{
    public static class SingleNumber
    {
        public static int Solution(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (map.ContainsKey(num)) map[num]++;
                else map[num] = 1;
            }

            foreach (var pair in map)
            {
                if (pair.Value == 1) return pair.Key;
            }

            return -1;
        }
    }
}
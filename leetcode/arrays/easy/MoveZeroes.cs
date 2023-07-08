#region Description

/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]
*/

#endregion

namespace leetcode.arrays.easy
{
    public static class MoveZeroes
    {
        public static void Solution(int[] nums)
        {
            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0) nums[i++] = nums[j];
            }

            for (; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
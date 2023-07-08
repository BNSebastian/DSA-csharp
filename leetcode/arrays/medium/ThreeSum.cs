#region Description

/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation:
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.

Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.

Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
*/

#endregion

namespace leetcode.arrays.medium
{
    public static class ThreeSum
    {
        public static List<List<int>> Solution(int[] nums)
        {
            Array.Sort(nums);

            var output = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                int target = -nums[i];

                while (left < right)
                {
                    int sum = nums[left] + nums[right];

                    if (sum > target)
                        right--;
                    else if (sum < target)
                        left++;
                    else
                    {
                        var entry = new List<int>() { nums[i], nums[left], nums[right] };
                        output.Add(entry);

                        while (nums[left] == entry[1] && left < right)
                            left++;
                        while (nums[right] == entry[2] && left < right)
                            right--;
                    }
                }

                // skip duplicate values
                while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                    i++;
            }

            return output;
        }
    }
}
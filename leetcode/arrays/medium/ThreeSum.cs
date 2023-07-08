using System;

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
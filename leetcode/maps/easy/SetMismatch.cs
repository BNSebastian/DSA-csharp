#region Description

/*
You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.

You are given an integer array nums representing the data status of this set after the error.

Find the number that occurs twice and the number that is missing and return them in the form of an array.

Example 1:

Input: nums = [1,2,2,4]
Output: [2,3]

Example 2:

Input: nums = [1,1]
Output: [1,2]
*/

#endregion

namespace leetcode.maps.easy
{
    public static class SetMismatch
    {
        public static int[] Solution(int[] nums)
        {
            int[] result = new int[2];

            var map = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (!map.ContainsKey(item)) map.Add(item, 1);
                else map[item]++;
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!map.ContainsKey(i))
                {
                    result[1] = i;
                    continue;
                }

                if (map[i] > 1) result[0] = i;
            }

            return result;
        }
    }
}
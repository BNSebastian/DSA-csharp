namespace leetcode.arrays.easy
{
    public static class ArrayPartition
    {
        public static int Solution(int[] nums)
        {
            Array.Sort(nums);

            int sum = 0;

            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += Math.Min(nums[i], nums[i + 1]);
            }

            return sum;
        }
    }
}
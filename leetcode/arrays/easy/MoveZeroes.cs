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
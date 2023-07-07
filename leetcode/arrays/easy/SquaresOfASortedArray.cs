namespace leetcode.arrays.easy
{
    public static class SquaresOfASortedArray
    {
        public static int[] SortedSquares(int[] nums)
        {
            var output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = (int)Math.Pow(nums[i], 2);
            }

            Array.Sort(output);
            return output;
        }
    }
}
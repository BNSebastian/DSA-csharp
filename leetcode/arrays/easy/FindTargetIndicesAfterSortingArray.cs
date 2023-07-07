namespace leetcode.arrays.easy
{
    public static class FindTargetIndicesAfterSortingArray
    {
        public static List<int> TargetIndices(int[] nums, int target)
        {
            Array.Sort(nums);

            var output = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) output.Add(i);
            }

            return output;
        }
    }
}
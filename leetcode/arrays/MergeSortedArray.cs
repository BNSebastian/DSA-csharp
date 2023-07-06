namespace leetcode.arrays
{
    public static class MergeSortedArray
    {
        public static void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums2, 0, nums1, m, n);
            Array.Sort(nums1);
        }
    }
}
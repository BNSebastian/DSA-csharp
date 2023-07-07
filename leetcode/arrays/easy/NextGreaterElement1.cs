namespace leetcode.arrays.easy
{
    public static class NextGreaterElement1
    {
        public static int[] Solution(int[] nums1, int[] nums2)
        {
            int[] output = new int[nums1.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                int j = Array.FindIndex(nums2, x => x == nums1[i]);

                for (; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        output[i] = nums2[j];
                        break;
                    }
                }

                if (j == nums2.Length)
                {
                    output[i] = -1;
                }
            }

            return output;
        }
    }
}
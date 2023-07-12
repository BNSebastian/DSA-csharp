namespace leetcode.maps.easy
{
    public static class IntersectionOfTwoArrays2
    {
        public static int[] Solution(int[] nums1, int[] nums2)
        {
            var map1 = new Dictionary<int, int>();
            var map2 = new Dictionary<int, int>();

            Array.Sort(nums1);
            Array.Sort(nums2);

            foreach (int item in nums1)
            {
                if (map1.ContainsKey(item)) map1[item] += 1;
                else map1[item] = 1;
            }

            foreach (int item in nums2)
            {
                if (map2.ContainsKey(item)) map2[item] += 1;
                else map2[item] = 1;
            }

            var output = new List<int>();

            foreach (var pair in map1)
            {
                if (map2.ContainsKey(pair.Key))
                {
                    for (int i = 1; i <= Math.Min(pair.Value, map2[pair.Key]); i++)
                        output.Add(pair.Key);
                }
            }

            return output.ToArray();
        }
    }
}
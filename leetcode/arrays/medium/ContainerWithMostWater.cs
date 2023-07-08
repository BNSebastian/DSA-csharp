using System.Collections.Generic;

namespace leetcode.arrays.medium
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1, maxWater = 0;

            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int currentWater = (right - left) * currentHeight;
                maxWater = Math.Max(maxWater, currentWater);

                while (height[right] <= currentHeight && left < right) right--;
                while (height[left] <= currentHeight && left < right) left++;
            }

            return maxWater;
        }
    }
}
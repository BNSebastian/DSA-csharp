namespace leetcode.arrays.easy
{
    public static class CanPlaceFlowers
    {
        public static bool PlaceLocally(int[] flowerbed, int index)
        {
            if (flowerbed[index] == 0 && flowerbed[index + 1] == 0 && flowerbed[index - 1] == 0)
            {
                return true;
            }
            return false;
        }

        public static bool Solution(int[] flowerbed, int n)
        {
            int size = flowerbed.Length;

            if (size == 1)
            {
                if (flowerbed[0] == 0) return 1 >= n;
                else return 0 >= n;
            }

            if (size == 2)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0) return 1 >= n;
                else return 0 >= n;
            }

            int count = 0;

            if (flowerbed[1] == 0 && flowerbed[0] == 0)
            {
                flowerbed[0] = 1;
                count++;
            }

            if (flowerbed[size - 1] == 0 && flowerbed[size - 2] == 0)
            {
                flowerbed[size - 1] = 1;
                count++;
            }

            for (int i = 1; i < flowerbed.Length - 1; i++)
            {
                if (PlaceLocally(flowerbed, i))
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }

            return count >= n;
        }
    }
}
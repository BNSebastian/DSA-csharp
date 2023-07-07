namespace leetcode.arrays.easy
{
    public static class PlusOne
    {
        public static int[] Solution(int[] digits)
        {
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += carry;
                if (digits[i] > 9)
                {
                    digits[i] %= 10;
                }
                else
                {
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                int[] extendedDigits = new int[digits.Length + 1];
                extendedDigits[0] = 1;
                Array.Copy(digits, 0, extendedDigits, 1, digits.Length);
                return extendedDigits;
            }

            return digits;
        }
    }
}
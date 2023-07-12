#region Description

/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1

Example 2:

Input: n = 2
Output: false
*/

#endregion

namespace leetcode.sets.easy
{
    public static class HappyNumber
    {
        public static int SquaredSum(int n)
        {
            var number = n.ToString();

            double result = 0;

            foreach (char c in number)
            {
                result += Math.Pow(double.Parse(c.ToString()), 2.0);
            }

            return (int)result;
        }

        public static bool Solution(int n)
        {
            HashSet<int> unique = new HashSet<int>();

            while (n != 1)
            {
                n = SquaredSum(n);
                if (unique.Contains(n)) return false;
                unique.Add(n);
            }

            return true;
        }
    }
}
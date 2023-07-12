#region Description

/*
Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.

Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.
*/

#endregion

namespace leetcode.maps.easy
{
    public static class LongestPalindrome
    {
        public static int Solution(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (map.ContainsKey(c)) map[c]++;
                else map[c] = 1;
            }

            int even = 0, odd = 0, oddEqualToOne = 0, oddMoreThanOne = 0;

            foreach (var pair in map)
            {
                if (pair.Value % 2 == 0) even += pair.Value;
                else
                {
                    odd += pair.Value;
                    if (pair.Value > 1) oddMoreThanOne++;
                    else oddEqualToOne++;
                }
            }

            int answer = even + odd - oddEqualToOne - oddMoreThanOne;

            // the middle odd value
            if (odd > 0) answer++;

            return answer;
        }
    }
}
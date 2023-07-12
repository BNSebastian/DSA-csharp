#region Description

/*
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

Example 1:

Input: s = "leetcode"
Output: 0

Example 2:

Input: s = "loveleetcode"
Output: 2

Example 3:

Input: s = "aabb"
Output: -1
*/

#endregion

namespace leetcode.maps.easy
{
    public static class FirstUniqueCharacterInAString
    {
        public static int Solution(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (map.ContainsKey(c)) map[c]++;
                else map[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1) return i;
            }

            return -1;
        }
    }
}
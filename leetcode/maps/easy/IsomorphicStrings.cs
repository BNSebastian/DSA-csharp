#region Description

/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

Example 1:

Input: s = "egg", t = "add"
Output: true

Example 2:

Input: s = "foo", t = "bar"
Output: false

Example 3:

Input: s = "paper", t = "title"
Output: true
*/

#endregion

namespace leetcode.maps.easy
{
    public static class IsomorphicStrings
    {
        public static bool Solution(string s, string t)
        {
            var aMapped = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (aMapped.ContainsKey(s[i]) && aMapped[s[i]] != t[i]) return false;
                else aMapped[s[i]] = t[i];
            }

            var bMapped = new Dictionary<char, char>();
            for (int i = 0; i < t.Length; i++)
            {
                if (bMapped.ContainsKey(t[i]) && bMapped[t[i]] != s[i]) return false;
                else bMapped[t[i]] = s[i];
            }

            return true;
        }
    }
}
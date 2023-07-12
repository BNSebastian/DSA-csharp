#region Description

/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true

Example 2:

Input: s = "rat", t = "car"
Output: false
*/

#endregion

namespace leetcode.maps.easy
{
    public static class ValidAnagram
    {
        public static bool Solution(string s, string t)
        {
            var map1 = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (map1.ContainsKey(c)) map1[c]++;
                else map1[c] = 1;
            }

            var map2 = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (map2.ContainsKey(c)) map2[c]++;
                else map2[c] = 1;
            }

            if (map1.Count != map2.Count) return false;

            foreach (var pair in map1)
            {
                if (!map2.ContainsKey(pair.Key)) return false;

                if (pair.Value != map2[pair.Key]) return false;
            }

            return true;
        }
    }
}
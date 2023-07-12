#region Description

/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true

Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false

Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
*/

#endregion

namespace leetcode.maps.easy
{
    public static class WordPattern
    {
        public static bool Solution(string pattern, string s)
        {
            string[] list = s.Split(' ');

            if (pattern.Length != list.Length) return false;

            Dictionary<char, string> map = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (map.ContainsKey(pattern[i]) && map[pattern[i]] != list[i]) return false;
                else map[pattern[i]] = list[i];
            }

            var distinct = new HashSet<string>();

            foreach (var pair in map) distinct.Add(pair.Value);

            return distinct.Count == map.Count;
        }
    }
}
#region Description

/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false

Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false

Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/

#endregion

namespace leetcode.maps.easy
{
    public static class RansomNote
    {
        public static bool Solution(string ransomNote, string magazine)
        {
            var mappedMagazine = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (mappedMagazine.ContainsKey(c)) mappedMagazine[c]++;
                else mappedMagazine.Add(c, 1);
            }

            var mappedRansomNote = new Dictionary<char, int>();
            foreach (char c in ransomNote)
            {
                if (mappedRansomNote.ContainsKey(c)) mappedRansomNote[c]++;
                else mappedRansomNote.Add(c, 1);
            }

            foreach (var pair in mappedRansomNote)
            {
                if (!mappedMagazine.ContainsKey(pair.Key)) return false;
                if (mappedMagazine[pair.Key] - pair.Value < 0) return false;
            }

            return true;
        }
    }
}
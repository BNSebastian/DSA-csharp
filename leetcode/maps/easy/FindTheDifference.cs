﻿#region Description

/*
You are given two strings s and t.

String t is generated by random shuffling string s and then add one more letter at a random position.

Return the letter that was added to t.

Example 1:

Input: s = "abcd", t = "abcde"
Output: "e"
Explanation: 'e' is the letter that was added.

Example 2:

Input: s = "", t = "y"
Output: "y"
*/

#endregion

namespace leetcode.maps.easy
{
    public static class FindTheDifference
    {
        public static char Solution(string s, string t)
        {
            var map1 = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (map1.ContainsKey(item)) map1[item]++;
                else map1[item] = 1;
            }

            var map2 = new Dictionary<char, int>();
            foreach (var item in t)
            {
                if (map2.ContainsKey(item)) map2[item]++;
                else map2[item] = 1;
            }

            foreach (var item in map2)
            {
                if (!map1.ContainsKey(item.Key) || item.Value != map1[item.Key]) return item.Key;
            }

            return '0';
        }
    }
}
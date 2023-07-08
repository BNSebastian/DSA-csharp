#region Description

/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

*/

#endregion

using System.Text;

namespace leetcode.strings.easy
{
    public static class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            Array.Sort(strs);
            var output = new StringBuilder();
            bool missmatch = false;

            for (int i = 0; i < strs[0].Length && missmatch != true; i++)
            {
                for (int j = 1; j < strs.Length && missmatch != true; j++)
                {
                    if (strs[j][i] == strs[0][i]) continue;
                    else missmatch = true;
                }

                if (!missmatch) output.Append(strs[0][i]);
            }

            return output.ToString();
        }
    }
}
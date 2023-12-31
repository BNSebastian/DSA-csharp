﻿#region Description

/*
You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.

Example 1:

Input: s = "abbaca"
Output: "ca"
Explanation:
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".

Example 2:

Input: s = "azxxzy"
Output: "ay"

*/

#endregion

namespace leetcode.stacks.easy
{
    public static class RemoveAllAdjacentDuplicatesInAString
    {
        public static string Solution(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                    continue;
                }

                if (c == stack.Peek()) stack.Pop();
                else stack.Push(c);
            }

            char[] arr = stack.ToArray();

            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
#region Description

/*
Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

Example 1:

Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".

Example 2:

Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".

Example 3:

Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".
*/

#endregion

namespace leetcode.stacks.easy
{
    public static class BackspaceStringCompare
    {
        public static string Solution(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '#')
                {
                    if (stack.Count == 0) continue;
                    else stack.Pop();
                }
                else stack.Push(c);
            }

            char[] chars = stack.ToArray();

            return new string(chars);
        }

        public static bool BackspaceCompare(string s, string t)
        {
            return Solution(s) == Solution(t);
        }
    }
}
#region Description

/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

Example 1:

Input: s = "()"
Output: true

Example 2:

Input: s = "()[]{}"
Output: true

Example 3:

Input: s = "(]"
Output: false
*/

#endregion

#region Description

/*

*/

#endregion

namespace leetcode.stacks.easy
{
    public static class ValidParantheses
    {
        public static bool IsValid(string phrase)
        {
            var stack = new Stack<char>();

            foreach (var item in phrase)
            {
                if (item == '(' || item == '{' || item == '[') stack.Push(item);
                else
                {
                    if (stack.Count == 0) return false;

                    if (item == ')' && stack.Peek() == '(') stack.Pop();
                    else if (item == '}' && stack.Peek() == '{') stack.Pop();
                    else if (item == ']' && stack.Peek() == '[') stack.Pop();
                    else return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
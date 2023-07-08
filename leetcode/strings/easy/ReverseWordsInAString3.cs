#region Description

/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"

Example 2:

Input: s = "God Ding"
Output: "doG gniD"

*/

#endregion

using System.Text;

namespace leetcode.strings.easy
{
    public static class ReverseWordsInAString3
    {
        public static string ReverseWords(string phrase)
        {
            string[] words = phrase.Split(' ');
            var output = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                var charArr = words[i].ToCharArray();
                Array.Reverse(charArr);

                output.Append(new string(charArr)).Append(" ");
            }

            return output.ToString().TrimEnd();
        }
    }
}
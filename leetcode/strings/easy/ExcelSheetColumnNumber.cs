﻿#region Description

/*
Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28
...

Example 1:

Input: columnTitle = "A"
Output: 1

Example 2:

Input: columnTitle = "AB"
Output: 28

Example 3:

Input: columnTitle = "ZY"
Output: 701
*/

#endregion

namespace leetcode.strings.easy
{
    public static class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            int output = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                int currentValue = (int)columnTitle[i] - 64;
                output = output * 26 + currentValue;
            }

            return output;
        }
    }
}
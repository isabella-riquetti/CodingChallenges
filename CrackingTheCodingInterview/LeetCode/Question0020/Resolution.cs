using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0020
{
    public static class Resolution
    {
        private static Dictionary<char, char> closes = new Dictionary<char, char>()
        {
            {')','(' },
            {']','[' },
            {'}','{' }
        };
        
        public static bool Solution1(string parenthesis)
            {
            var stack = new Stack<char>();
            foreach (var item in parenthesis)
            {
                if (item == '(' || item == '[' || item == '{')
                    stack.Push(item);
                else if (stack.Count == 0)
                    return false;
                else
                {
                    var closing = closes[item];
                    var previousCharClose = stack.Pop();
                    if (previousCharClose != closing)
                    {
                        return false;
                    }
                }
            }
        
            return stack.Count == 0;
        }
    }
}
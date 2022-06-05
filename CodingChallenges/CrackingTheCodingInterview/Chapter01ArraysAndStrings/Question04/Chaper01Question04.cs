using System;
using System.Collections.Generic;

namespace CodingChallenges.CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question04
{
    public static class Chaper01Question04
    {
        // Time: O(n)
        // Space: O(n)
        public static bool Solution1(string text)
        {
            var hashSet = new HashSet<char>();
            text = text.Replace(" ", String.Empty).ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                if (hashSet.Contains(text[i]))
                {
                    hashSet.Remove(text[i]);
                }
                else
                {
                    hashSet.Add(text[i]);
                }
            }

            if (text.Length % 2 == 0)
            {
                return hashSet.Count == 0;
            }
            return hashSet.Count == 1;
        }
    }
}
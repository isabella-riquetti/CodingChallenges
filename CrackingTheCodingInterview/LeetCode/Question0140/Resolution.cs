using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0140
{
    public static class Resolution
    {
        public static IList<string> Solution1(string s, IList<string> wordDict)
        {
            var results = new List<string>();
            GetValidWords(s, new HashSet<string>(wordDict), results, 0, "", "");
            return results;
        }

        public static void GetValidWords(string s, HashSet<string> words, IList<string> result, int index, string phrase, string currentString)
        {
            if (index == s.Length)
            {
                if(phrase.Replace(" ","").Length == s.Length)
                    result.Add(phrase.Trim());

                return;
            }
            currentString += s[index];
            index++;

            if (words.Contains(currentString))
            {
                GetValidWords(s, words, result, index, phrase + currentString + " ", "");
            }

            GetValidWords(s, words, result, index, phrase, currentString);
            
        }
    }
}
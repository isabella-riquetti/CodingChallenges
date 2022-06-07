using System;
using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class ValidateSubsequence
    {
        // Time: O(a*s)
        // Space: O(1)
        public static bool Solution1(List<int> array, List<int> sequence)
        {
            int arrIndex = 0;
            for (int i = 0; i < sequence.Count; i++)
            {
                bool found = false;
                while (arrIndex < array.Count)
                {
                    if (array[arrIndex++] == sequence[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }

        // Time: O(a)
        // Space: O(1)
        public static bool Solution2(List<int> array, List<int> sequence)
        {
            int arrIndex = 0;
            int seqIndex = 0;
            while (array.Count > arrIndex && sequence.Count > seqIndex)
            {
                if (array[arrIndex] == sequence[seqIndex])
                    seqIndex++;
                arrIndex++;
            }
            return seqIndex == sequence.Count;
        }        
    }
}

using System;
using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class NonConstructibleChange
    {
        // Time: O(nlogn)
        // Space: O(1)
        public static int Solution1(int[] coins)
        {
            Array.Sort(coins);

            int currentChangeCreated = 0;
            foreach (var coin in coins)
            {
                if (coin > currentChangeCreated + 1)
                    return currentChangeCreated + 1;

                currentChangeCreated += coin;
            }
            return currentChangeCreated + 1;
        }
    }
}

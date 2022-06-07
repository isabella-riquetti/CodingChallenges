using System;
using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class SortedSquaredArray
    {
        // Time: O(n)
        // Space: O(n)
        public static int[] Solution1(int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            var squares = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(array[startIndex]) > Math.Abs(array[endIndex]))
                {
                    squares[i] = array[startIndex] * array[startIndex];
                    startIndex++;
                }
                else
                {
                    squares[i] = array[endIndex] * array[endIndex];
                    endIndex--;
                }
            }

            return squares;
        }
    }
}

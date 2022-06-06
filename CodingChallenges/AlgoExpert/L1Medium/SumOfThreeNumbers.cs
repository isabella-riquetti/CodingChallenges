using System;
using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Medium
{
    public static class SumOfThreeNumbers
    {
        // O(n²) complexity
        // O(n) space
        public static List<int[]> Solution1(int[] array, int targetSum)
        {
            Array.Sort(array);
            var result = new List<int[]>();
            for (int currentIndex = 0; currentIndex < array.Length-2; currentIndex++)
            {
                int left = currentIndex + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int currentSum = array[currentIndex] + array[left] + array[right];
                    if (currentSum == targetSum)
                        result.Add(new int[3] { array[currentIndex], array[left], array[right] });

                    if (currentSum >= targetSum)
                        right--;
                    if (currentSum <= targetSum)
                        left++;
                }

            }

            return result;
        }
    }
}

using System;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class SumOfTwoNumbers
    {
        // Time: O(n²)
        // Space: O(1)
        public static int[] Solution1(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return new int[2] { array[i], array[j] };
                    }
                }

            }
            return new int[0];
        }

        // Time: O(n²)
        // Space: O(1)
        public static int[] Solution2(int[] array, int targetSum)
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return new int[2] { array[i], array[j] };
                    }
                    else if (array[i] + array[j] > targetSum)
                    {
                        break;
                    }
                }

            }
            return new int[0];
        }
        
        // Time: O(n)
        // Space: O(1)
        public static int[] Solution3(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (right > left)
            {
                int sum = array[left] + array[right];
                if (sum == targetSum)
                    return new int[2] { array[left], array[right] };
                if (sum < targetSum)
                    left++;
                else
                    right--;
            }
            return new int[0];
        }
    }
}

using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0047
{
    public static class Resolution
    {
        public static IList<IList<int>> Solution1(int[] nums)
        {
            var result = new List<IList<int>>();
            PossibleContinuations(nums, new HashSet<int>(), result, new List<int>());
            return result;
        }

        public static void PossibleContinuations(int[] nums, HashSet<int> usedIndexes, IList<IList<int>> result, IList<int> currentList)
        {
            var numbersUsedInThePosition = new HashSet<int>(nums.Length - usedIndexes.Count);
            for (int i = 0; i < nums.Length; i++)
            {
                if (usedIndexes.Contains(i) || numbersUsedInThePosition.Contains(nums[i]))
                {
                    continue;
                }
                else
                {
                    var newList = new List<int>(currentList);
                    var newUsedIndexes = new HashSet<int>(usedIndexes);
                    numbersUsedInThePosition.Add(nums[i]);
                    newList.Add(nums[i]);
                    newUsedIndexes.Add(i);
                    if (newList.Count == nums.Length)
                    {
                        result.Add(newList);
                    }
                    else
                    {
                        PossibleContinuations(nums, newUsedIndexes, result, newList);
                    }
                }
            }
        }
    }
}
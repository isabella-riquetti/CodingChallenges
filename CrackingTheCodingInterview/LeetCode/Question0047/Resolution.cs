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
        
        public static IList<IList<int>> Solution2(int[] nums)
        {
            var result = new List<IList<int>>();
            PermuteUnique(nums, 0, result);
            return result;
        }
        public static void PermuteUnique(int[] nums, int index, IList<IList<int>> result)
        {
            if (index == nums.Length) // Add once it reachs the max index
            {
                result.Add(new List<int>(nums));
                return;
            }

            HashSet<int> usedValuesInThePosition = new HashSet<int>();
            for (int i = index; i < nums.Length; i++)
            {
                if (usedValuesInThePosition.Contains(nums[i])) // Avoid duplications
                    continue;
                else
                    usedValuesInThePosition.Add(nums[i]);

                Swap(nums, index, i); // Swap values to be used in the next permutations

                PermuteUnique(nums, index + 1, result); // Will permute the index with all theother next positions

                Swap(nums, index, i); // Swap back so it can keep on the loop with the prevvalue
            }
        }
        public static void Swap(int[] nums, int i, int j)
        {
            var aux = nums[i];
            nums[i] = nums[j];
            nums[j] = aux;
        }
    }
}
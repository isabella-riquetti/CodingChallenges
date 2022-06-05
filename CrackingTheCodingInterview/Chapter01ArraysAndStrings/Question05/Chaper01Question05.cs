namespace CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question05
{
    public static class Chaper01Question05
    {
        // Time: O(n) where N is the size of the biggest string
        // Space: O(1)
        public static bool Solution1(string text1, string text2)
        {
            string bigger = text2.Length > text1.Length ? text2 : text1;
            string smaller = text2.Length <= text1.Length ? text2 : text1;
            bool increaseIndexAfterDifference = true;
            if (bigger.Length - smaller.Length > 1) // Remove strings that has more than 2 characters difference
            {
                return false;
            }
            else if (text1.Length == text2.Length) // Should me a simple replacement
            {
                increaseIndexAfterDifference = false;
            }

            bool alreadyDifferent = false;
            for (int i = 0; i < bigger.Length; i++)
            {
                if (i == bigger.Length - 1 && !alreadyDifferent) // Added at the last index
                {
                    return true;
                }

                bool isEqual = bigger[i] == smaller[i - (alreadyDifferent && increaseIndexAfterDifference ? 1 : 0)];
                if (!isEqual)
                {
                    if (!alreadyDifferent)
                    {
                        alreadyDifferent = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
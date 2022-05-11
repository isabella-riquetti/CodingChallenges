using System;

namespace CrackingTheCodingInterview.LeetCode.Question0278
{
    public static class Resolution
    {
        public static int FirstBadVersion(int n, int firstBad)
        {
            int min = 1;
            int max = n;
            while (min <= max)
            {
                int middle = (max + min) / 2;
                bool isBadVersion = IsBadVersion(middle, firstBad);

                if (Math.Abs(min - max) <= 1)
                {
                    if (isBadVersion)
                        return middle;
                    else
                        return ++middle;
                }

                if (isBadVersion)
                {
                    max = middle;
                }
                else
                {
                    min = middle;
                }

            }

            return -1;
        }
        
        private static bool IsBadVersion(int n, int firstBad)
        {
            return n >= firstBad;
        }
    }
}
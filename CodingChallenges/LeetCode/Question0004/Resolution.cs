using System;

namespace CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0004
{
    public static class Resolution
    {
        public static double Solution1(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 && nums2.Length == 0)
                return 0;

            var totalLength = nums1.Length + nums2.Length - 1;
            var medianPos = totalLength / 2.0;

            int pos1 = 0;
            int pos2 = 0;
            var totalPos = 0.0;
            int middle = 0;
            while (totalPos <= Math.Ceiling(medianPos))
            {
                int currentNum = 0;

                if (pos2 >= nums2.Length || (pos1 < nums1.Length && nums1[pos1] < nums2[pos2]))
                {
                    currentNum = nums1[pos1];
                    pos1++;
                }
                else if (pos2 < nums2.Length)
                {
                    currentNum = nums2[pos2];
                    pos2++;
                }

                if (totalPos == Math.Floor(medianPos))
                    middle += currentNum;
                if (totalPos == Math.Ceiling(medianPos))
                    middle += currentNum;

                totalPos++;
            }

            return middle / 2.0;
        }
    }
}
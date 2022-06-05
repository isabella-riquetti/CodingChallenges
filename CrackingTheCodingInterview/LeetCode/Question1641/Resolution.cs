namespace CrackingTheCodingInterview.LeetCode.Question1641
{
    public static class Resolution
    {
        public static int Solution1(int n)
        {
            return ValidSequences(new int[4] { 0, 0, 0, 0 }, 0, n);
        }

        public static int ValidSequences(int[] sumPrevIndex, int index, int maxIndex)
        {
            if (index < maxIndex)
            {
                int[] sum = new int[4];
                sum[3] = sumPrevIndex[3] + 1;
                sum[2] = sumPrevIndex[2] + sum[3];
                sum[1] = sumPrevIndex[1] + sum[2];
                sum[0] = sumPrevIndex[0] + sum[1];
                return ValidSequences(sum, index + 1, maxIndex);
            }

            return sumPrevIndex[0] + sumPrevIndex[1] + sumPrevIndex[2] + sumPrevIndex[3] + 1;
        }


        public static int Solution2(int n)
        {
            int[] sums = new int[5] { 1, 1, 1, 1, 1 };
            while (--n > 0)
            {
                sums[3] += sums[4];
                sums[2] += sums[3];
                sums[1] += sums[2];
                sums[0] += sums[1];
            }

            return sums[4] + sums[3] + sums[2] + sums[1] + sums[0];
        }
    }
}
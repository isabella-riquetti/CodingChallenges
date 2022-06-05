using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0066
{
    public static class Resolution
    {
        public static int[] Solution1(int[] digits)
        {
            var list = new List<int>();
            int pendingIncrement = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + pendingIncrement;
                if (num == 10)
                {
                    pendingIncrement = 1;
                    num = 0;
                }
                else
                    pendingIncrement = 0;

                list.Add(num);
            }

            if (pendingIncrement == 1)
                list.Add(pendingIncrement);

            list.Reverse();
            return list.ToArray();
        }

        public static int[] Solution2(int[] digits)
        {
            int pendingIncrement = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + pendingIncrement;
                if (num == 10)
                {
                    pendingIncrement = 1;
                    num = 0;
                }
                else
                    pendingIncrement = 0;

                digits[i] = num;
            }

            if (pendingIncrement == 1)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
            }

            return digits;
        }
    }
}
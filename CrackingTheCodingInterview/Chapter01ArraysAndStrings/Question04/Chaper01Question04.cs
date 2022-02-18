using System;

namespace CrackingTheCodingInterview.Chapter1ArraysAndStrings.Question1
{
    public static class Chaper01Question04
    {
        ////Time O(n), Space O(1)
        //public static bool Solution1(string text)
        //{
        //    int half = Convert.ToInt32(Math.Floor(text.Length / 2.0));
        //    for (int i = 0; i < half; i++)
        //    {
        //        if (text[i] != text[text.Length - i])
        //            return false;
        //    }

        //    return true;

        //}

        public static bool Solution1(string text)
        {
            int half = Convert.ToInt32(Math.Floor(text.Length / 2.0));
            for (int i = 0; i < half; i++)
            {
                if (text[i] != text[text.Length - i])
                    return false;
            }

            return true;

        }
    }
}
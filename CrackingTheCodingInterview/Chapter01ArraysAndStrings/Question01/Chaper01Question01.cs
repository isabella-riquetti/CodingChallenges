using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question01
{
    public static class Chaper01Question01
    {
        public static bool Solution1HashSet(string text)
        {
            if (text.Length > char.MaxValue)
                return false;

            HashSet<char> characters = new HashSet<char>();
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                if (characters.Contains(character))
                    return false;

                characters.Add(character);
            }

            return true;
        }

        public static bool Solution2BoolList(string text)
        {
            if (text.Length > char.MaxValue)
                return false;

            bool[] characters = new bool[char.MaxValue + 1];
            for (int i = 0; i < text.Length; i++)
            {
                int charIndex = (int)text[i];
                if (characters[charIndex])
                    return false;

                characters[charIndex] = true;
            }

            return true;
        }

        public static bool Solution3BruteForceNoAdditionalDataStructure(string text)
        {
            if (text.Length > char.MaxValue)
                return false;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                        return false;
                }
            }

            return true;
        }

        // Only possible for letters and numbers
        public static bool Solution4Bitwise(string text)
        {
            long checker = 0;
            for (int i = 0; i < text.Length; i++)
            {
                // Check for lower case
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    // Get lower case index
                    int charInt = text[i] - 'a';
                    if ((checker & (1 << charInt)) > 0)
                        return false;

                    checker |= 1 << charInt;
                }
                // Check for upper case
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    // Get upper case index and adds maximum of lower case
                    int charInt = text[i] - 'A' + 'z' - 'a';
                    if ((checker & (1 << charInt)) > 0)
                        return false;

                    checker |= 1 << charInt;
                }
                // Check for numbers
                else if (text[i] >= '0' && text[i] <= '9')
                {
                    // Get number index and adds letters
                    int charInt = text[i] - '0' + 'z' - 'a' + 'Z' - 'A';
                    if ((checker & (1 << charInt)) > 0)
                        return false;

                    checker |= (long)1 << charInt;
                }
                else
                {
                    throw new Exception("Invalid character");
                }
            }


            return true;
        }
    }
}

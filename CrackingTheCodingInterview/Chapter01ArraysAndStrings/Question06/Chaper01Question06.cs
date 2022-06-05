using System.Text;

namespace CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question06
{
    public static class Chaper01Question06
    {
        // Time: O(s)
        // Space: O(1)
        public static string Solution1(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            char prevChar = text[0];
            int counter = 1;
            StringBuilder builder = new StringBuilder();
            builder.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (builder.Length > text.Length)
                    return text; // Avoid going to the end of the string if the new one is already bigger

                if (text[i] == prevChar)
                    counter++;
                else
                {
                    builder.Append(counter);
                    builder.Append(text[i]);
                    prevChar = text[i];
                    counter = 1;
                }
            }

            builder.Append(counter);
            if (builder.Length > text.Length)
                return text;

            return builder.ToString();
        }
    }
}
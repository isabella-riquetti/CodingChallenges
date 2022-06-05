using System.Text;

namespace CodingChallenges.CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question03
{
    public static class Chaper01Question03
    {
        //Time O(n), Space O(1)
        public static string Solution1(string text)
        {
            StringBuilder strBuilder = new StringBuilder();
            bool started = false;
            string currentConcat = ""; // To avoid adding spaces at the end
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    started = true;
                    strBuilder.Append(currentConcat);
                    strBuilder.Append(text[i]);
                    currentConcat = "";
                }
                else if (started)
                {
                    currentConcat += "%20";
                }
            }

            return strBuilder.ToString();
        }

        //Mixed solution, Time O(n), Space O(1)
        public static string Solution2(string text)
        {
            text = text.Trim();
            string[] newStr = new string[text.Length];
            for (int i = 0; i < text.Length; i++)
                newStr[i] = text[i] == ' ' ? "%20" : text[i].ToString();

            return string.Join("", newStr);
        }

        //Mixed solution, Time O(n), Space O(1)
        public static string Solution3(string text)
        {
            StringBuilder strBuilder = new StringBuilder();
            text = text.Trim();
            for (int i = 0; i < text.Length; i++)
                strBuilder.Append(text[i] == ' ' ? "%20" : text[i]);

            return strBuilder.ToString();
        }

        //Using string lib, Time O(1), Space O(1)
        public static string Solution4(string text)
        {
            return text.Trim().Replace(" ", "%20");
        }

        //Using string lib, Time O(1), Space O(1)
        public static string Solution5(string text)
        {
            StringBuilder strBuilder = new StringBuilder(text.Trim());
            strBuilder.Replace(" ", "%20");
            return strBuilder.ToString();
        }

        //Book approach first try, Time O(1), Space O(1)
        public static string Solution6(string text)
        {
            text = text.Trim();
            int spaceCount = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == ' ')
                    spaceCount++;

            char[] chars = new char[text.Length + (2 * spaceCount)];
            int charPos = chars.Length - 1;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == ' ')
                {
                    chars[charPos] = '0';
                    chars[--charPos] = '2';
                    chars[--charPos] = '%';
                }
                else
                {
                    chars[charPos] = text[i];
                }
                charPos--;
            }

            return string.Join("", chars);
        }
    }
}

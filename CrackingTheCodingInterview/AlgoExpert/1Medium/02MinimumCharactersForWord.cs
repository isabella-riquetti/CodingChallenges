using System.Collections.Generic;

namespace CrackingTheCodingInterview.AlgoExpert.Medium
{
    public static class MinimumCharactersForWord
    {
        public static string[] Solution1(string[] words)
        {
            int[] usedCharsAmount = new int[128];
            for (int i = 0; i < words.Length; i++)
            {
                int[] currentWordUsedCharsAmount = new int[128];
                for (int c = 0; c < words[i].Length; c++)
                {
                    int index = char.ToUpper(words[i][c]);
                    currentWordUsedCharsAmount[index]++;
                    if (currentWordUsedCharsAmount[index] > usedCharsAmount[index])
                        usedCharsAmount[index] = currentWordUsedCharsAmount[index];
                }
            }

            var answer = new List<string>();
            for (int i = 0; i < usedCharsAmount.Length; i++)
            {
                for (int c = 0; c < usedCharsAmount[i]; c++)
                {
                    answer.Add(((char)i).ToString());
                }
            }
            return answer.ToArray();
        }

        public static string[] Solution2(string[] words)
        {
            var charCounter = new Dictionary<char, int>();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWordCharCounter = new Dictionary<char, int>();
                for (int c = 0; c < words[i].Length; c++)
                    _UpdateCurrentWordCounter(currentWordCharCounter, words[i][c]);

                _UpdateCharCounter(charCounter, currentWordCharCounter);
            }
            return _GetUsedChars(charCounter);
        }

        private static void _UpdateCurrentWordCounter(Dictionary<char, int> currentWordCharCounter, char key)
        {
            if (!currentWordCharCounter.ContainsKey(key))
                currentWordCharCounter.Add(key, 1);
            else
                currentWordCharCounter[key]++;
        }
        private static void _UpdateCharCounter(Dictionary<char, int> charCounter, Dictionary<char, int> currentWordCharCounter)
        {
            foreach (KeyValuePair<char, int> dicValue in currentWordCharCounter)
            {
                if (!charCounter.ContainsKey(dicValue.Key))
                    charCounter.Add(dicValue.Key, dicValue.Value);
                else if (charCounter[dicValue.Key] < dicValue.Value)
                    charCounter[dicValue.Key] = dicValue.Value;
            }
        }
        private static string[] _GetUsedChars(Dictionary<char, int> charCounter)
        {
            var answer = new List<string>();
            foreach (KeyValuePair<char, int> dicValue in charCounter)
                for (int c = 0; c < dicValue.Value; c++)
                    answer.Add(dicValue.Key.ToString());

            return answer.ToArray();
        }
    }
}

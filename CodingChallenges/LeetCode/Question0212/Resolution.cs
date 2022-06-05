using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0212
{
    public static class Resolution
    {
        // Require improvement to be faster
        public static IList<string> Solution1(char[][] board, string[] words)
        {
            var results = new HashSet<string>();

            for (int row = 0; row < board.Length; row++)
                for (int col = 0; col < board[row].Length; col++)
                    Move(board, words.ToList(), results, 0, row, col, new HashSet<string>());

            return results.ToList();
        }
        private static void Move(char[][] board, List<string> words, HashSet<string> results, int index, int row, int col, HashSet<string> usedPositions)
        {
            var validWords = MoovementValidWords(board, index, words, row, col, usedPositions, results);
            if (validWords.Count > 0)
                SearchWord(board, validWords, results, index + 1, row, col, usedPositions);
        }

        private static void SearchWord(char[][] board, List<string> words, HashSet<string> results, int index, int row, int col, HashSet<string> usedPositions)
        {
            if (row - 1 >= 0 && !usedPositions.Contains((row - 1) + ":" + col)) // Go Up
            {
                Move(board, words, results, index, row - 1, col, new HashSet<string>(usedPositions));
            }
            if (row + 1 < board.Length && !usedPositions.Contains((row + 1) + ":" + col)) // Go Down
            {
                Move(board, words, results, index, row + 1, col, new HashSet<string>(usedPositions));
            }
            if (col - 1 >= 0 && !usedPositions.Contains(row + ":" + (col - 1))) // Go Left
            {
                Move(board, words, results, index, row, col - 1, new HashSet<string>(usedPositions));
            }
            if (col + 1 < board[row].Length && !usedPositions.Contains(row + ":" + (col + 1))) // Go Right
            {
                Move(board, words, results, index, row, col + 1, new HashSet<string>(usedPositions));
            }
        }

        private static List<string> MoovementValidWords(char[][] board, int index, List<string> words, int row, int col, HashSet<string> usedPositions, HashSet<string> results)
        {
            var validWords = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i][index] == board[row][col] && !results.Contains(words[i]))
                {
                    if (words[i].Length != index + 1)
                    {
                        usedPositions.Add(row + ":" + col);
                        validWords.Add(words[i]);
                    }
                    else
                        results.Add(words[i]);
                }
            }
            return validWords;
        }
    }
}
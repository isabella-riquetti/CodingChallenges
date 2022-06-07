using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class TournamentWinner
    {
        // Time: O(n)
        // Space: O(n)
        public static string Solution1(List<List<string>> competitions, List<int> results)
        {
            var dict = new Dictionary<string, int>();
            string winner = "";
            int winnerPoints = 0;
            for (int i = 0; i < results.Count; i++)
            {
                var roundWinner = competitions[i][results[i] == 0 ? 1 : 0];
                if (dict.ContainsKey(roundWinner))
                    dict[roundWinner]++;
                else
                    dict.Add(roundWinner, 1);

                if (dict[roundWinner] > winnerPoints)
                {
                    winnerPoints = dict[roundWinner];
                    winner = roundWinner;
                }
            }

            return winner;
        }
    }
}

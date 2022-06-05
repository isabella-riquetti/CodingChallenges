using CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Medium;
using Xunit;
namespace CodingChallenges.Test.CrakingTheCodingInterview.AlgoExpert
{
    public class AlgoExpertDebug
    {
        [Fact]
        // Just to debug, I can use AlgoExpert platform to test
        public void Test()
        {
            var words = new string[] { "this", "that", "did", "dead", "them!", "a" };
            var result = MinimumCharactersForWord.Solution1(words);

            Assert.Equal(result, result);
        }
    }
}

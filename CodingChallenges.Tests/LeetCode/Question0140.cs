using CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0140;
using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Test.CrakingTheCodingInterview.LeetCode
{
    public class Question0140
    {
        [Theory]
        [MemberData(nameof(PossiblePhrasesTests))]
        public void Solution1(PossiblePhrasesTestInput test)
        {
            var result = Resolution.Solution1(test.Text, test.Words);

            test.ExpecteResult.Should().BeEquivalentTo(result);
        }

        public static TheoryData<PossiblePhrasesTestInput> PossiblePhrasesTests = new TheoryData<PossiblePhrasesTestInput>
        {
            new PossiblePhrasesTestInput()
            {
                Text = "catsanddog",
                Words = new List<string>() { "cat", "cats", "and", "sand", "dog" },
                ExpecteResult = new List<string>() { "cats and dog", "cat sand dog" }
            },
            new PossiblePhrasesTestInput()
            {
                Text = "pineapplepenapple",
                Words = new List<string>() { "apple","pen","applepen","pine","pineapple" },
                ExpecteResult = new List<string>() { "pine apple pen apple", "pineapple pen apple", "pine applepen apple" }
            }
        };

        [ExcludeFromCodeCoverage]
        public class PossiblePhrasesTestInput
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public IList<string> Words { get; set; }
            public IList<string> ExpecteResult { get; set; }
        }

    }
}

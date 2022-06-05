using CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0212;
using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Test.CrakingTheCodingInterview.LeetCode
{
    public class Question0212
    {
        [Theory]
        [MemberData(nameof(PossiblePhrasesTests))]
        public void Solution1(PossiblePhrasesTestInput test)
        {
            var result = Resolution.Solution1(test.Board, test.Words);

            test.ExpecteResult.Should().BeEquivalentTo(result);
        }

        public static TheoryData<PossiblePhrasesTestInput> PossiblePhrasesTests = new TheoryData<PossiblePhrasesTestInput>
        {
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'o', 'a', 'a', 'n' },
                    new char[] { 'e', 't', 'a', 'e' },
                    new char[] { 'i', 'h', 'k', 'r' },
                    new char[] { 'i', 'f', 'l', 'v' }
                },
                Words = new string[] { "oath","pea","eat","rain","oafish" },
                ExpecteResult = new List<string>() { "eat", "oath" }
            },
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'a' }
                },
                Words = new string[] { "a" },
                ExpecteResult = new List<string>() { "a" }
            },
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'o', 'a', 'b', 'n' },
                    new char[] { 'o', 't', 'a', 'e' },
                    new char[] { 'a', 'h', 'k', 'r' },
                    new char[] { 'a', 'f', 'l', 'v' }
                },
                Words = new string[] { "oa", "oaa" },
                ExpecteResult = new List<string>() { "oa", "oaa" }
            },
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'a', 'a' }
                },
                Words = new string[] { "aa" },
                ExpecteResult = new List<string>() { "aa" }
            },
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'a', 'a' }
                },
                Words = new string[] { "aaa" },
                ExpecteResult = new List<string>()
            },
            new PossiblePhrasesTestInput()
            {
                Board = new char[][] {
                    new char[] { 'o','a','a','n'},
                    new char[] {'e','t','a','e'},
                    new char[] {'i','h','k','r'},
                    new char[] {'i','f','l','v'}
                },
                Words = new string[] { "oath","pea","eat","rain","oathi","oathk","oathf","oate","oathii","oathfi","oathfii" },
                ExpecteResult = new List<string>() {"oath","oathk","oathf","oathfi","oathfii","oathi","oathii","oate","eat"}
            }
        };

        [ExcludeFromCodeCoverage]
        public class PossiblePhrasesTestInput
        {
            public string Name { get; set; }
            public char[][] Board { get; set; }
            public string[] Words { get; set; }
            public IList<string> ExpecteResult { get; set; }
        }

    }
}

using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.LeetCode
{
    public class Question0047
    {
        [Theory]
        [MemberData(nameof(PermutationsNoRepetitionsTests))]
        public void Solution1(PermutationsNoRepetitionsTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question0047.Resolution.Solution1(test.Value);

            test.ExpecteResult.Should().BeEquivalentTo(result);
        }

        [Theory]
        [MemberData(nameof(PermutationsNoRepetitionsTests))]
        public void Solution2(PermutationsNoRepetitionsTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question0047.Resolution.Solution2(test.Value);

            test.ExpecteResult.Should().BeEquivalentTo(result);
        }

        public static TheoryData<PermutationsNoRepetitionsTestInput> PermutationsNoRepetitionsTests = new TheoryData<PermutationsNoRepetitionsTestInput>
        {
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "121",
                Value = new int[] { 1,2,1 },
                ExpecteResult = new List<IList<int>>()
                {
                    new List<int>() { 1,1,2 },
                    new List<int>() { 1,2,1 },
                    new List<int>() { 2,1,1 },
                }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "111",
                Value = new int[] { 1,2,1 },
                ExpecteResult = new List<IList<int>>()
                {
                    new List<int>() { 1,1,2 },
                    new List<int>() { 1,2,1 },
                    new List<int>() { 2,1,1 },
                }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "123",
                Value = new int[] { 1,2,3 },
                ExpecteResult = new List<IList<int>>()
                {
                    new List<int>() { 1,2,3 },
                    new List<int>() { 1,3,2 },
                    new List<int>() { 2,1,3 },
                    new List<int>() { 2,3,1 },
                    new List<int>() { 3,1,2 },
                    new List<int>() { 3,2,1 },
                }
            }
        };

        [ExcludeFromCodeCoverage]
        public class PermutationsNoRepetitionsTestInput
        {
            public string Name { get; set; }
            public int[] Value { get; set; }
            public IList<IList<int>> ExpecteResult { get; set; }
        }

    }
}

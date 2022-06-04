using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.LeetCode
{
    public class Question0066
    {
        [Theory]
        [MemberData(nameof(PlusOneTests))]
        public void Solution1(PlusOneTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question0066.Resolution.Solution1(test.Digits);

            result.Should().BeEquivalentTo(test.ExpecteResult);
        }
        
        [Theory]
        [MemberData(nameof(PlusOneTests))]
        public void Solution2(PlusOneTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question0066.Resolution.Solution2(test.Digits);

            result.Should().BeEquivalentTo(test.ExpecteResult);
        }

        public static TheoryData<PlusOneTestInput> PlusOneTests = new TheoryData<PlusOneTestInput>
        {
            new PlusOneTestInput()
            {
                Name = "Increase list",
                Digits = new int[] { 9 },
                ExpecteResult = new int[] { 1, 0 }
            },
            new PlusOneTestInput()
            {
                Name = "Increase list",
                Digits = new int[] { 9, 9 },
                ExpecteResult = new int[] { 1, 0, 0 }
            },
            new PlusOneTestInput()
            {
                Name = "Bignumber list",
                Digits = new int[] { 9,8,7,6,5,4,3,2,1,0 },
                ExpecteResult = new int[] { 9,8,7,6,5,4,3,2,1,1 }
            }
        };

        [ExcludeFromCodeCoverage]
        public class PlusOneTestInput
        {
            public string Name { get; set; }
            public int[] Digits { get; set; }
            public int[] ExpecteResult { get; set; }
        }

    }
}

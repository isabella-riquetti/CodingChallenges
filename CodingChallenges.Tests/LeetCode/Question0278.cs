using CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0278;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Test.CrakingTheCodingInterview.LeetCode
{
    public class Question0278
    {
        [Theory]
        [MemberData(nameof(FirstBadVersionTests))]
        public void Solution1(FirstBadVersionTestInput test)
        {
            var result = Resolution.FirstBadVersion(test.Max, test.FirstBad);

            Assert.Equal(test.FirstBad, result);
        }

        public static TheoryData<FirstBadVersionTestInput> FirstBadVersionTests = new TheoryData<FirstBadVersionTestInput>
        {
            new FirstBadVersionTestInput()
            {
                Max = 5,
                FirstBad = 4
            },
            new FirstBadVersionTestInput()
            {
                Max = 1,
                FirstBad = 1
            },
            new FirstBadVersionTestInput()
            {
                Max = 2,
                FirstBad = 2
            },
            new FirstBadVersionTestInput()
            {
                Max = 3,
                FirstBad = 1
            }
        };

        [ExcludeFromCodeCoverage]
        public class FirstBadVersionTestInput
        {
            public int Max { get; set; }
            public int FirstBad { get; set; }
        }

    }
}

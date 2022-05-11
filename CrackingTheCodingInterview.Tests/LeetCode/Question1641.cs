using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.LeetCode
{
    public class Question1641
    {
        [Theory]
        [MemberData(nameof(CountSortedVowelStringsTests))]
        public void Solution1(CountSortedVowelStringsTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question1641.Resolution.Solution1(test.Value);
            
            Assert.Equal(test.ExpecteResult, result);
        }
        [Theory]
        [MemberData(nameof(CountSortedVowelStringsTests))]
        public void Solution2(CountSortedVowelStringsTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question1641.Resolution.Solution2(test.Value);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<CountSortedVowelStringsTestInput> CountSortedVowelStringsTests = new TheoryData<CountSortedVowelStringsTestInput>
        {
            new CountSortedVowelStringsTestInput()
            {
                Name = "1 vowel",
                Value = 1,
                ExpecteResult = 5
            },
            new CountSortedVowelStringsTestInput()
            {
                Name = "2 vowels",
                Value = 2,
                ExpecteResult = 15
            },
            new CountSortedVowelStringsTestInput()
            {
                Name = "33 vowels",
                Value = 33,
                ExpecteResult = 66045
            }
        };

        [ExcludeFromCodeCoverage]
        public class CountSortedVowelStringsTestInput
        {
            public string Name { get; set; }
            public int Value { get; set; }
            public int ExpecteResult { get; set; }
        }

    }
}

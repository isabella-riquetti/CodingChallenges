using CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question04;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrackingTheCodingInterview.Tests.Chapter01ArraysAndStrings
{
    public class Question04
    {
        [Theory]
        [MemberData(nameof(PermutationPalindromeTests))]
        public void Solution1(PermutationPalindromeTestInput test)
        {
            var result = Chaper01Question04.Solution1(test.Text);

            Assert.Equal(test.ExpecteResult, result);
        }


        public static TheoryData<PermutationPalindromeTestInput> PermutationPalindromeTests = new TheoryData<PermutationPalindromeTestInput>
        {
            new PermutationPalindromeTestInput()
            {
                Name = "Basic text",
                Text = "Tact Coa",
                ExpecteResult = true
            }
        };

        [ExcludeFromCodeCoverage]
        public class PermutationPalindromeTestInput
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public bool ExpecteResult { get; set; }
        }
    }
}

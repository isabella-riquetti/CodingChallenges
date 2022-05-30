using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.LeetCode
{
    public class Question0020
    {
        [Theory]
        [MemberData(nameof(ParethesisValidationTests))]
        public void Solution1(ParethesisValidationTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question0020.Resolution.Solution1(test.Input);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<ParethesisValidationTestInput> ParethesisValidationTests = new TheoryData<ParethesisValidationTestInput>
        {
            new ParethesisValidationTestInput()
            {
                Name = "Empty",
                Input = "",
                ExpecteResult = true
            },
            new ParethesisValidationTestInput()
            {
                Name = "Valid single",
                Input = "[]",
                ExpecteResult = true
            },
            new ParethesisValidationTestInput()
            {
                Name = "Valid mix side-by-side",
                Input = "()[]{}",
                ExpecteResult = true
            },
            new ParethesisValidationTestInput()
            {
                Name = "Valid mix in between",
                Input = "([{}])",
                ExpecteResult = true
            },
            new ParethesisValidationTestInput()
            {
                Name = "Valid mix in between and side by side",
                Input = "([{}])([]){}",
                ExpecteResult = true
            },
            new ParethesisValidationTestInput()
            {
                Name = "Invalid closing",
                Input = ")",
                ExpecteResult = false
            },
            new ParethesisValidationTestInput()
            {
                Name = "Invalid missing",
                Input = "()[",
                ExpecteResult = false
            },
            new ParethesisValidationTestInput()
            {
                Name = "Invalid different",
                Input = "(]",
                ExpecteResult = false
            },
            new ParethesisValidationTestInput()
            {
                Name = "Invalid mix",
                Input = "[(])",
                ExpecteResult = false
            },
        };

        [ExcludeFromCodeCoverage]
        public class ParethesisValidationTestInput
        {
            public string Name { get; set; }
            public string Input { get; set; }
            public bool ExpecteResult { get; set; }
        }

    }
}

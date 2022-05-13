using CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question06;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrackingTheCodingInterview.Tests.Chapter01ArraysAndStrings
{
    public class Question06
    {
        [Theory]
        [MemberData(nameof(StringCompressionTests))]
        public void Solution1(StringCompressionTestInput test)
        {
            var result = Chaper01Question06.Solution1(test.Text);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<StringCompressionTestInput> StringCompressionTests = new()
        {
            new StringCompressionTestInput()
            {
                Name = "Normal replaced",
                Text = "aabcccccaaa",
                ExpecteResult = "a2b1c5a3"
            },
            new StringCompressionTestInput()
            {
                Name = "Replacement is bigger",
                Text = "abcdefgh",
                ExpecteResult = "abcdefgh"
            },
            new StringCompressionTestInput()
            {
                Name = "Replacement equal",
                Text = "aa",
                ExpecteResult = "a2"
            },
            new StringCompressionTestInput()
            {
                Name = "Replacement is bigger",
                Text = "a",
                ExpecteResult = "a"
            },
            new StringCompressionTestInput()
            {
                Name = "Empty",
                Text = "",
                ExpecteResult = ""
            }
        };

        [ExcludeFromCodeCoverage]
        public class StringCompressionTestInput
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public string ExpecteResult { get; set; }
        }
    }
}

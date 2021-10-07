using CrackingTheCodingInterview.Chapter1ArraysAndStrings.Question1;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.Chapter_1___Arrays_and_String
{
    public class Question2
    {
        [Theory]
        [MemberData(nameof(PermutationTests))]
        public void Solution1(PermutationTestInput test)
        {
            var result = Chaper01Question02.Solution1(test.StrA, test.StrB);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(PermutationTests))]
        public void Solution2(PermutationTestInput test)
        {
            var result = Chaper01Question02.Solution2(test.StrA, test.StrB);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(PermutationTests))]
        public void Solution3(PermutationTestInput test)
        {
            var result = Chaper01Question02.Solution3(test.StrA, test.StrB);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(PermutationTests))]
        public void Solution4(PermutationTestInput test)
        {
            var result = Chaper01Question02.Solution4(test.StrA, test.StrB);

            Assert.Equal(test.ExpectedResult, result);
        }

        public static TheoryData<PermutationTestInput> PermutationTests = new TheoryData<PermutationTestInput>
        {
            new PermutationTestInput()
            {
                Name = "Basic positive",
                StrA = "abcd",
                StrB = "bcda",
                ExpectedResult = true
            },
            new PermutationTestInput()
            {
                Name = "Basic positive, upper cases",
                StrA = "abcd",
                StrB = "DaBc",
                ExpectedResult = true
            },
            new PermutationTestInput()
            {
                Name = "Basic negative",
                StrA = "abce",
                StrB = "DaBc",
                ExpectedResult = false
            },
            new PermutationTestInput()
            {
                Name = "Bid example positive",
                StrA = "pneumonoultramicroscopicsilicovolcanoconiosis",
                StrB = "aacccccceiiiiiilllmmnnnnooooooooopprrsssstuuv",
                ExpectedResult = true
            },
        };

        [ExcludeFromCodeCoverage]
        public class PermutationTestInput
        {
            public string Name { get; set; }
            public string StrA { get; set; }
            public string StrB { get; set; }
            public bool ExpectedResult { get; set; }
        }
    }
}

using CodingChallenges.CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question01;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;

namespace CodingChallenges.Tests.CrackingTheCodingInterview.Chapter01ArraysAndStrings
{
    public class Question01
    {
        [Theory]
        [MemberData(nameof(OnlyUniqueCharactersTests))]
        public void Solution1HashSetTest(OnlyUniqueCharactersTestInput test)
        {
            var result = Chaper01Question01.Solution1HashSet(test.InputText);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(OnlyUniqueCharactersTests))]
        public void Solution2BoolListTest(OnlyUniqueCharactersTestInput test)
        {
            var result = Chaper01Question01.Solution2BoolList(test.InputText);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(OnlyUniqueCharactersTests))]
        public void Solution3BruteForceNoAdditionalDataStructureTest(OnlyUniqueCharactersTestInput test)
        {
            var result = Chaper01Question01.Solution3BruteForceNoAdditionalDataStructure(test.InputText);

            Assert.Equal(test.ExpectedResult, result);
        }

        [Theory]
        [MemberData(nameof(OnlyUniqueCharactersTestsNoSymbols))]
        public void Solution4BitwiseTest(OnlyUniqueCharactersTestInput test)
        {
            if (test.ExpectedException)
            {
                Assert.Throws<Exception>(() => Chaper01Question01.Solution4Bitwise(test.InputText));
            }
            else
            {
                var result = Chaper01Question01.Solution4Bitwise(test.InputText);
                Assert.Equal(test.ExpectedResult, result);
            }

        }

        public static TheoryData<OnlyUniqueCharactersTestInput> OnlyUniqueCharactersTests = new TheoryData<OnlyUniqueCharactersTestInput>
        {
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Basic positive",
                InputText = "fabio",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Basic negative",
                InputText = "sandra",
                ExpectedResult = false
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Case sensitive",
                InputText = "isabelLA",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Empty",
                InputText = "",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Max size",
                InputText = String.Join("", Enumerable.Range('\x1', char.MaxValue+1).Select(c => (char)c)),
                ExpectedResult = false
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Stress true",
                InputText = String.Join("", Enumerable.Range('\x1', char.MaxValue).Select(c => (char)c)),
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Stress false",
                InputText = String.Join("", Enumerable.Range('\x1', char.MaxValue-1).Select(c => (char)c)) + "a",
                ExpectedResult = false
            }
        };

        public static TheoryData<OnlyUniqueCharactersTestInput> OnlyUniqueCharactersTestsNoSymbols = new TheoryData<OnlyUniqueCharactersTestInput>
        {
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Basic lower",
                InputText = "az",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Basic upper",
                InputText = "AXZ",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Basic number",
                InputText = "0123456789",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Mixed, valid",
                InputText = "4bCd3aBcDe",
                ExpectedResult = true
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Invalid",
                InputText = "4bCd3aBcDeEE",
                ExpectedResult = false
            },
            new OnlyUniqueCharactersTestInput()
            {
                Name = "Exception",
                InputText = "*&#!@&)!",
                ExpectedResult = false,
                ExpectedException = true
            }
        };

        [ExcludeFromCodeCoverage]
        public class OnlyUniqueCharactersTestInput
        {
            public string Name { get; set; }
            public string InputText { get; set; }
            public bool ExpectedResult { get; set; }
            public bool ExpectedException { get; set; }
        }
    }
}

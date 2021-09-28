﻿using CrackingTheCodeInterview.Chapter1ArraysAndStrings.Question1;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Xunit;

namespace CrakingTheCodeInterview.Test.Chapter_1___Arrays_and_String
{
    public class Question1
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

        [ExcludeFromCodeCoverage]
        public class OnlyUniqueCharactersTestInput
        {
            public string Name { get; set; }
            public string InputText { get; set; }
            public bool ExpectedResult { get; set; }
        }
    }
}
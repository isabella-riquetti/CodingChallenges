using CodingChallenges.CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question07;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Tests.CrackingTheCodingInterview.Chapter01ArraysAndStrings
{
    public class Question07
    {
        [Theory]
        [MemberData(nameof(RotateMatrixTests))]
        public void Solution1(PermutationsNoRepetitionsTestInput test)
        {
            var result = Chaper01Question07.Solution1(test.Value);

            Assert.Equal(test.ExpecteResult, result);
        }

        [Theory]
        [MemberData(nameof(RotateMatrixTests2))]
        public void Solution2(PermutationsNoRepetitionsTestInput test)
        {
            var result = Chaper01Question07.Solution2(test.Value);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<PermutationsNoRepetitionsTestInput> RotateMatrixTests = new TheoryData<PermutationsNoRepetitionsTestInput>
        {
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "2 matrix",
                Value = new short[,] { { 1, 2 }, { 3, 4 } },
                ExpecteResult = new short[,] { { 3, 1 },{ 4, 2 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "3 matrix",
                Value = new short[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                ExpecteResult = new short[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "4 matrix",
                Value = new short[,] { { 1, 2, 3, 4 }, { 5,6,7,8 }, { 9,10,11,12 }, { 13,14,15,16 } },
                ExpecteResult = new short[,] { { 13,9,5,1 }, { 14,10,6,2 }, { 15,11,7,3 }, { 16,12,8,4 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "5 matrix",
                Value = new short[,] { { 1,2,3,4,5 }, { 6,7,8,9,10 }, { 11,12,13,14,15 }, { 16,17,18,19,20 }, { 21,22,23,24,25 } },
                ExpecteResult = new short[,] { { 21, 16, 11, 6, 1 }, { 22, 17, 12, 7, 2 }, { 23, 18, 13, 8, 3 }, { 24, 19, 14, 9, 4 }, { 25, 20, 15, 10, 5 } }
            }
        };

        public static TheoryData<PermutationsNoRepetitionsTestInput> RotateMatrixTests2 = new TheoryData<PermutationsNoRepetitionsTestInput>
        {
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "2 matrix",
                Value = new short[,] { { 1, 2 }, { 3, 4 } },
                ExpecteResult = new short[,] { { 3, 1 },{ 4, 2 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "3 matrix",
                Value = new short[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                ExpecteResult = new short[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "4 matrix",
                Value = new short[,] { { 1, 2, 3, 4 }, { 5,6,7,8 }, { 9,10,11,12 }, { 13,14,15,16 } },
                ExpecteResult = new short[,] { { 13,9,5,1 }, { 14,10,6,2 }, { 15,11,7,3 }, { 16,12,8,4 } }
            },
            new PermutationsNoRepetitionsTestInput()
            {
                Name = "5 matrix",
                Value = new short[,] { { 1,2,3,4,5 }, { 6,7,8,9,10 }, { 11,12,13,14,15 }, { 16,17,18,19,20 }, { 21,22,23,24,25 } },
                ExpecteResult = new short[,] { { 21, 16, 11, 6, 1 }, { 22, 17, 12, 7, 2 }, { 23, 18, 13, 8, 3 }, { 24, 19, 14, 9, 4 }, { 25, 20, 15, 10, 5 } }
            }
        };

        [ExcludeFromCodeCoverage]
        public class PermutationsNoRepetitionsTestInput
        {
            public string Name { get; set; }
            public short[,] Value { get; set; }
            public short[,] ExpecteResult { get; set; }
        }

    }
}

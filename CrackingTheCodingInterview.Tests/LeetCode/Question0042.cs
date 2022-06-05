//using CrackingTheCodingInterview.LeetCode.Question0042;
//using System.Diagnostics.CodeAnalysis;
//using Xunit;

//namespace CrakingTheCodeInterview.Test.LeetCode
//{
//    public class Question0042
//    {
//        [Theory]
//        [MemberData(nameof(PitSizeTests))]
//        public void Solution1(PitSizeTestInput test)
//        {
//            var result = Resolution.Solution1(test.Heights);

//            Assert.Equal(test.ExpecteResult, result);
//        }

//        public static TheoryData<PitSizeTestInput> PitSizeTests = new TheoryData<PitSizeTestInput>
//        {
//            new PitSizeTestInput()
//            {
//                Name = "Empty",
//                Heights = new int[0],
//                ExpecteResult = 0
//            },
//            new PitSizeTestInput()
//            {
//                Name = "Multiple pits",
//                Heights = new int[] { 6, 4, 4, 2, 3, 5, 1, 3, 1, 3 },
//                ExpecteResult = 11
//            },
//            new PitSizeTestInput()
//            {
//                Name = "Multiple pits",
//                Heights = new int[] { 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 },
//                ExpecteResult = 6
//            },
//            new PitSizeTestInput()
//            {
//                Name = "Lower pit",
//                Heights = new int[] { 1, 0, 2 },
//                ExpecteResult = 1
//            },
//        };

//        [ExcludeFromCodeCoverage]
//        public class PitSizeTestInput
//        {
//            public string Name { get; set; }
//            public int[] Heights { get; set; }
//            public int ExpecteResult { get; set; }
//        }

//    }
//}

using CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0004;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Test.CrakingTheCodingInterview.LeetCode
{
    public class Question0004
    {
        [Theory]
        [MemberData(nameof(MedianOfTwoSortedArraysTests))]
        public void Solution1(MedianOfTwoSortedArraysTestInput test)
        {
            var result = Resolution.Solution1(test.Nums1, test.Nums2);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<MedianOfTwoSortedArraysTestInput> MedianOfTwoSortedArraysTests = new TheoryData<MedianOfTwoSortedArraysTestInput>
        {
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "Median odd",
                Nums1 = new int[] {1,3},
                Nums2 = new int[] {2},
                ExpecteResult = 2
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "Median even",
                Nums1 = new int[] {1,3},
                Nums2 = new int[] {2,4},
                ExpecteResult = 2.5
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "First empty",
                Nums1 = new int[0],
                Nums2 = new int[] {1,2,3},
                ExpecteResult = 2
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "Second empty",
                Nums1 = new int[] {1,2,3},
                Nums2 = new int[0],
                ExpecteResult = 2
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "First empty and second with one",
                Nums1 = new int[0],
                Nums2 = new int[] {1},
                ExpecteResult = 1
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "Second empty and first with one",
                Nums1 = new int[] {1},
                Nums2 = new int[0],
                ExpecteResult = 1
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "Both empty",
                Nums1 = new int[0],
                Nums2 = new int[0],
                ExpecteResult = 0
            },
            new MedianOfTwoSortedArraysTestInput()
            {
                Name = "All zeros",
                Nums1 = new int[] {0,0,0},
                Nums2 = new int[] {0,0,0},
                ExpecteResult = 0
            }
        };

        [ExcludeFromCodeCoverage]
        public class MedianOfTwoSortedArraysTestInput
        {
            public string Name { get; set; }
            public int[] Nums1 { get; set; }
            public int[] Nums2 { get; set; }
            public double ExpecteResult { get; set; }
        }

    }
}

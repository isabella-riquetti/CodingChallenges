using CodingChallenges.CrakingTheCodingInterviewLeetCode.Question0117;
using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CodingChallenges.Test.CrakingTheCodingInterview.LeetCode
{
    public class Question0117
    {
        [Theory]
        [MemberData(nameof(PopulateNextRightPointerTests))]
        public void Solution1(PopulateNextRightPointerTestInput test)
        {
            var result = Resolution.Solution1(test.Value);

            test.ExpecteResult.Should().BeEquivalentTo(result);
        }

        public static TheoryData<PopulateNextRightPointerTestInput> PopulateNextRightPointerTests = new TheoryData<PopulateNextRightPointerTestInput>
        {
            new PopulateNextRightPointerTestInput()
            {
                Name = "Connected",
                Value = new Node()
                {
                    val = 1,
                    right = new Node()
                    {
                        val = 3,
                        right = new Node()
                        {
                            val = 7
                        },
                        left = new Node()
                        {
                            val = 8
                        }
                    },
                    left = new Node()
                    {
                        val = 2,
                        right = new Node()
                        {
                            val = 5
                        },
                        left = new Node()
                        {
                            val = 4
                        }
                    }
                },
                ExpecteResult = new Node()
                {
                    val = 1,
                    right = new Node()
                    {
                        val = 3,
                        right = new Node()
                        {
                            val = 7
                        },
                        left = new Node()
                        {
                            val = 8,
                            next = new Node()
                            {
                                val = 7
                            }
                        }
                    },
                    left = new Node()
                    {
                        val = 2,
                        next = new Node()
                        {
                            val = 3,
                            right = new Node()
                            {
                                val = 7
                            },
                            left = new Node()
                            {
                                val = 8,
                                next = new Node()
                                {
                                    val = 7
                                }
                            }
                        },
                        right = new Node()
                        {
                            val = 5,
                            next = new Node()
                            {
                                val = 8,
                                next = new Node()
                                {
                                    val = 7
                                }
                            }
                        },
                        left = new Node()
                        {
                            val = 4,
                            next = new Node()
                            {
                                val = 5,
                                next = new Node()
                                {
                                    val = 8,
                                    next = new Node()
                                    {
                                        val = 7
                                    }
                                }
                            }
                        }
                    }
                },
            }
        };

        [ExcludeFromCodeCoverage]
        public class PopulateNextRightPointerTestInput
        {
            public string Name { get; set; }
            public Node Value { get; set; }
            public Node ExpecteResult { get; set; }
            public Dictionary<int, Node> Nodes { get; set; }
        }

    }
}

using CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question05;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrackingTheCodingInterview.Tests.Chapter01ArraysAndStrings
{
    public class Question05
    {
        [Theory]
        [MemberData(nameof(EditsTests))]
        public void Solution1(EditsTestInput test)
        {
            var result = Chaper01Question05.Solution1(test.Text1, test.Text2);

            Assert.Equal(test.ExpecteResult, result);
        }

        public static TheoryData<EditsTestInput> EditsTests = new TheoryData<EditsTestInput>
        {
            new EditsTestInput()
            {
                Name = "Removed",
                Text1 = "pale",
                Text2 = "ple",
                ExpecteResult = true
            },
            new EditsTestInput()
            {
                Name = "More then one removal",
                Text1 = "pales",
                Text2 = "ple",
                ExpecteResult = false
            },
            new EditsTestInput()
            {
                Name = "Added",
                Text1 = "pale",
                Text2 = "pales",
                ExpecteResult = true
            },
            new EditsTestInput()
            {
                Name = "More then one addition",
                Text1 = "ple",
                Text2 = "pales",
                ExpecteResult = false
            },
            new EditsTestInput()
            {
                Name = "Replaced",
                Text1 = "pale",
                Text2 = "tale",
                ExpecteResult = true
            },
            new EditsTestInput()
            {
                Name = "More than one replacement",
                Text1 = "pale",
                Text2 = "bake",
                ExpecteResult = false
            },
        };

        [ExcludeFromCodeCoverage]
        public class EditsTestInput
        {
            public string Name { get; set; }
            public string Text1 { get; set; }
            public string Text2 { get; set; }
            public bool ExpecteResult { get; set; }
        }
    }
}

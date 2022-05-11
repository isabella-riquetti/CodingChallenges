using CrackingTheCodingInterview.AlgoExpert;
using Xunit;
using static CrackingTheCodingInterview.AlgoExpert.Hard1ShiftLinkedList;

namespace CrakingTheCodeInterview.Test.AlgoExpert
{
    public class AlgoExpertDebug
    {
        [Fact]
        // Just to debug, I can use AlgoExpert platform to test
        public void Medium1RiverSizesDebug()
        {
            var matrix = new int[5, 5]
            {
                { 1,0,0,1,1 },
                { 1,0,0,1,1 },
                { 0,1,1,0,1 },
                { 1,0,1,1,1 },
                { 0,0,0,1,0 },
            };
            var result = Medium1RiverSizes.RiverSizes(matrix);

            Assert.Equal(result, result);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(8, 4)]
        [InlineData(-2, 2)]
        [InlineData(0, 0)]
        // Just to debug, I can use AlgoExpert platform to test
        public void Hard1ShiftLinkedListDebug(int k, int resultValue)
        {
            var linkedList5 = new LinkedList(5);
            var linkedList4 = new LinkedList(4);
            linkedList4.next = linkedList5;
            var linkedList3 = new LinkedList(3);
            linkedList3.next = linkedList4;
            var linkedList2 = new LinkedList(2);
            linkedList2.next = linkedList3;
            var linkedList1 = new LinkedList(1);
            linkedList1.next = linkedList2;
            var linkedList0 = new LinkedList(0);
            linkedList0.next = linkedList1;
            var result = Hard1ShiftLinkedList.ShiftLinkedList(linkedList0, k);

            Assert.Equal(resultValue, result.value);
        }
    }
}

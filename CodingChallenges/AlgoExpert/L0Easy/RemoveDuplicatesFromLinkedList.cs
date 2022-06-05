namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Easy
{
    public static class RemoveDuplicatesFromLinkedList
    {
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public static LinkedList Solution1(LinkedList linkedList)
        {
            LinkedList currentNode = linkedList;
            LinkedList previousNode = null;
            while (currentNode != null)
            {
                if (currentNode.value == previousNode?.value)
                    previousNode.next = currentNode.next;
                else
                    previousNode = currentNode;

                currentNode = currentNode.next;
            }
            return linkedList;
        }
    }
}

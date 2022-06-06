using System.Collections.Generic;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Hard
{
    public static class FindLoop
    {
        // Time: O(n)
        // Space: O(n)
        public static LinkedList Solution1(LinkedList head)
        {
            var existingValues = new HashSet<LinkedList>();
            var curr = head;
            while (!existingValues.Contains(curr))
            {
                existingValues.Add(curr);
                curr = curr.next;
            }
            return curr;
        }
        
        // Time: O(n)
        // Space: O(1)
        public static LinkedList Solution2(LinkedList head)
        {
            var turtle = head.next;
            var rabbit = head.next.next;
            while (rabbit != turtle)
            {
                turtle = turtle.next;
                rabbit = rabbit.next.next;
            }
            var turtle2 = head;
            while (turtle != turtle2)
            {
                turtle = turtle.next;
                turtle2 = turtle2.next;
            }
            return turtle;
        }

        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                next = null;
            }
        }
    }
}

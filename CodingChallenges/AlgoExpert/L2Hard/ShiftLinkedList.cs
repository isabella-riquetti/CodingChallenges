using System;

namespace CodingChallenges.CrakingTheCodingInterviewAlgoExpert.Hard
{
    public static class ShiftLinkedList
    {
        public static LinkedList Solution1(LinkedList head, int k)
        {
            int n = 1;
            LinkedList curr = head;
            while (curr.next != null)
            {
                n++;
                curr = curr.next;
            }

            int abs = Math.Abs(k) % n;
            if (abs == 0)
            {
                return head;
            }

            int pointer = k < 0 ? abs : n - abs;
            LinkedList tail = head;
            for (int i = 1; i < pointer; i++)
            {
                tail = tail.next;
            }

            LinkedList newHead = tail.next;
            curr.next = head;
            tail.next = null;
            return newHead;
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
